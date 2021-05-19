using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Business_logic
{
    public class GRASPManager
    {
        private float vehicleCapacity;

        private int vehicleCount;

        private List<float> currentVehicleCapasity;

        private List<Instance> dataset;

        private const int SOFT_DUE_WINDOW = 15;

        private int SOFT_READY_WINDOW = 50;

        private const int SOFT_READY_WINDOW_MAX = 250;

        private const double COEF_WAIT_PENALTY = 0.05;

        public GRASPManager(List<Instance> dataset, int vehicleCount, float vehicleCapacity)
        {
            this.vehicleCapacity = vehicleCapacity;
            this.vehicleCount = vehicleCount;
            this.dataset = dataset;
            InitVehicleCapacityAndTW();
        }

        #region private methods

        private void InitVehicleCapacityAndTW()
        {
            currentVehicleCapasity = new List<float>();
            for (int i = 0; i < vehicleCount; i++)
            {
                currentVehicleCapasity.Add(0);
            }
        }

        private List<List<int>> CopySolution(List<List<int>> route)
        {
            List<List<int>> newList = new List<List<int>>();
            foreach (var item in route)
            {
                List<int> tmp = new List<int>();
                foreach (int num in item)
                {
                    tmp.Add(num);
                }
                newList.Add(tmp);
            }

            return newList;
        }

        private void ResetCapacityAndTime()
        {
            for (int i = 0; i < vehicleCount; i++)
            {
                currentVehicleCapasity[i] = 0;
            }
        }

        private bool isRoutesSame(List<List<int>> route1, List<List<int>> route2)
        {
            for (int i = 0; i < route1.Count; i++)
            {
                for (int j = 0; j < route1[i].Count; j++)
                {
                    if (route1[i][j] != route2[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // TwoOpt Algorithm
        private List<int> twoOptSwap(List<int> route, int i, int j)
        {
            List<int> newRoute = route.GetRange(0, i);
            int reverseSize = j - i + 1;
            List<int> reverseRoute = route.GetRange(i, reverseSize);
            reverseRoute.Reverse();
            int restSize = route.Count - (j + 1);
            List<int> endRoute = route.GetRange(j + 1, restSize);
            newRoute.AddRange(reverseRoute);
            newRoute.AddRange(endRoute);
            return newRoute;
        }

        private bool CanExistWithCurrentTimeWindows(List<int> newRoute)
        {
            double currentTime = 0.0;

            for (int i = 0; i < newRoute.Count; i++)
            {
                var intstance1 = dataset.FirstOrDefault(item => item.ID == newRoute[i]);
                Instance instance2;
                if (i + 1 == newRoute.Count)
                {
                    instance2 = dataset.FirstOrDefault(item => item.ID == newRoute[0]);
                }
                else
                {
                    instance2 = dataset.FirstOrDefault(item => item.ID == newRoute[i + 1]);
                }

                double currDist = FindLength(intstance1, instance2);


                double futureTime = currentTime + currDist;
                bool timeWindowCriteria = (futureTime < (instance2.DueTime + SOFT_DUE_WINDOW));

                if (timeWindowCriteria)
                {
                    currentTime += currDist + instance2.ServiceTime;
                }
                else
                {
                    return false;
                }
            }


            return true;
        }

        private void CalculatePenalties(List<int> newRoute, out double latePenalty, out double waitPenalty)
        {
            double currentTime = 0.0;
            latePenalty = 0.0;
            waitPenalty = 0.0;

            for (int i = 0; i < newRoute.Count; i++)
            {
                var intstance1 = dataset.FirstOrDefault(item => item.ID == newRoute[i]);
                Instance instance2;
                if (i + 1 == newRoute.Count)
                {
                    instance2 = dataset.FirstOrDefault(item => item.ID == newRoute[0]);
                }
                else
                {
                    instance2 = dataset.FirstOrDefault(item => item.ID == newRoute[i + 1]);
                }

                double currDist = FindLength(intstance1, instance2);


                double futureTime = currentTime + currDist;

                if(futureTime > instance2.DueTime && futureTime < (instance2.DueTime + SOFT_DUE_WINDOW))
                {
                    latePenalty += futureTime - instance2.DueTime;
                }

                if (futureTime < instance2.ReadyTime)
                {
                    waitPenalty += instance2.ReadyTime - currentTime;
                }               
            }
        }

        private void CalculatePenaltiesForAllRoute(List<List<int>> newRoute, out double latePenaltyGlobal, out double waitPenaltyGlobal)
        {
            waitPenaltyGlobal = 0.0;
            latePenaltyGlobal = 0.0;

            foreach(var route in newRoute)
            {
                CalculatePenalties(route, out double latePenaltyLocal, out double waitPenaltyLocal);
                waitPenaltyGlobal += waitPenaltyLocal;
                latePenaltyGlobal += latePenaltyLocal;
            }
        }

        public double EvaluateGlobalRoute(List<List<int>> newRoute)
        {
            CalculatePenaltiesForAllRoute(newRoute, out double latePenaltyGlobal, out double waitPenaltyGlobal);

            double dist = CalculateDistanceValueForAllRouteWithVehicles(dataset, newRoute);

            return dist + latePenaltyGlobal + waitPenaltyGlobal * COEF_WAIT_PENALTY;
        }


        private void ResetDataset()
        {
            for (int i = 0; i < dataset.Count; i++)
            {
                this.dataset[i].IsDone = false;
            }
        }

        private List<int> GreedyAlgorithm(int currentVehicleIndex, double alpha = 0.2)
        {
            var route = new List<int>();
            int counter = 0;

            do
            {
                route.Clear(); 
                int startPoint = 0;
                double currentTime = 0.0;

                route.Add(startPoint);
                dataset.FirstOrDefault(item => item.ID == startPoint).IsDone = true;

                while (!dataset.All(item => item.IsDone))
                {
                    var distDict = CalculateDistance(startPoint);

                    if (distDict.Count == 0)
                        break;

                    double cMin = distDict.Min(x => x.Value);

                    double cMax = distDict.Max(x => x.Value);

                    double criteria = cMin + 0.2 * (cMax - cMin);
                    double demandCriteria = vehicleCapacity - currentVehicleCapasity[currentVehicleIndex];

                    Random random = new Random();

                    var RCL = new HashSet<int>();
                    foreach (var dist in distDict)
                    {
                        var tmp_inst = dataset.FirstOrDefault(item => item.ID == dist.Key);

                        double futureTime = currentTime + dist.Value;
                        bool timeWindowCriteria = (futureTime < tmp_inst.DueTime + SOFT_DUE_WINDOW) && (
                            (tmp_inst.ReadyTime - currentTime) < SOFT_READY_WINDOW || counter > 99);

                        if (dist.Value <= criteria && tmp_inst.Demand <= demandCriteria && timeWindowCriteria)
                        {
                            RCL.Add(dist.Key);
                        }
                    }

                    if (RCL.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        var prevStartPoint = dataset.FirstOrDefault(item => item.ID == startPoint);
                        startPoint = RCL.ElementAt(random.Next(RCL.Count));
                        var inst = dataset.FirstOrDefault(item => item.ID == startPoint);
                        currentVehicleCapasity[currentVehicleIndex] += inst.Demand;

                        float dist = (float)FindLength(inst, prevStartPoint);

                        double futureTime = currentTime + dist;
                        if (futureTime < inst.ReadyTime)
                        {
                            currentTime = inst.ReadyTime;
                        }

                        currentTime += dist + inst.ServiceTime;

                        route.Add(startPoint);

                        dataset.FirstOrDefault(item => item.ID == startPoint).IsDone = true;
                    }
                }
                route.Add(0);

                counter++;
            } while (!CanExistWithCurrentTimeWindows(route) || route.Count <= 2);

            return route;
        }

        private Dictionary<int, double> CalculateDistance(int startPoint)
        {
            var dist = new Dictionary<int, double>();

            for (int i = 0; i < dataset.Count; i++)
            {
                if (i == startPoint || dataset[i].IsDone)
                    continue;

                dist.Add(dataset[i].ID, FindLength(dataset[startPoint], dataset[i]));
            }

            return dist;
        }

        private double FindLength(Instance instance1, Instance instance2)
                 => Math.Sqrt(Math.Pow((instance1.X - instance2.X), 2) + Math.Pow((instance1.Y - instance2.Y), 2));

        private List<List<int>> LocalSearch(List<List<int>> currentRoute)
        {
            int k = 0;
            while (k < 50)
            {
                var oldRouteBeforeLocalSearch = CopySolution(currentRoute);
                for (int g = 0; g < currentRoute.Count; g++)
                {
                    for (int i = 1; i < currentRoute[g].Count - 2; i++)
                    {
                        for (int j = i + 1; j < currentRoute[g].Count; j++)
                        {
                            double oldRouteQuality = EvaluateRoute(currentRoute[g]);

                            var newRoute = twoOptSwap(currentRoute[g], i, j);

                            double newRouteQuality = EvaluateRoute(newRoute);

                            if (newRouteQuality < oldRouteQuality && CanExistWithCurrentTimeWindows(newRoute))
                            {
                                currentRoute[g] = newRoute;
                            }
                        }
                    }
                }

                if (isRoutesSame(currentRoute, oldRouteBeforeLocalSearch))
                {
                    break;
                }
                k++;
            }

            return currentRoute;
        }

        #endregion

        public List<List<int>> Execute(out List<List<int>> initialResult, double alpha = 0.2)
        {
            initialResult = new List<List<int>>();
            for (int z = 0; z < vehicleCount && !dataset.All(item => item.IsDone); z++)
            {
                initialResult.Add(GreedyAlgorithm(z));
            }
            var bestSolution = CopySolution(initialResult);
            var currentRoute = CopySolution(initialResult);

            int iterator = 0;
            while (iterator < 15)
            {
                if (iterator != 0)
                {
                    ResetDataset();
                    ResetCapacityAndTime();
                    currentRoute.Clear();
                    for (int z = 0; z < vehicleCount && !dataset.All(item => item.IsDone); z++)
                    {
                        currentRoute.Add(GreedyAlgorithm(z));
                    }
                }

                LocalSearch(currentRoute);

                double oldQuality = EvaluateGlobalRoute(bestSolution);
                double currentQuality = EvaluateGlobalRoute(currentRoute);
               
                if (currentQuality < oldQuality)
                {
                    bestSolution = CopySolution(currentRoute);
                }
                iterator++;
            }

            return bestSolution;
        }

        private double EvaluateRoute(List<int> route)
        {
            double dist = CalculateDistanceValueForAllRoute(route);

            CalculatePenalties(route, out double latePenalty, out double waitPenalty);

            return dist + latePenalty + waitPenalty * COEF_WAIT_PENALTY;
        }

        public double CalculateDistanceValueForAllRoute(List<int> route)
        {
            double sum = 0;

            for (int i = 0; i < route.Count; i++)
            {
                var intstance1 = dataset.FirstOrDefault(item => item.ID == route[i]);
                Instance instance2;
                if (i + 1 == route.Count)
                {
                    instance2 = dataset.FirstOrDefault(item => item.ID == route[0]);
                }
                else
                {
                    instance2 = dataset.FirstOrDefault(item => item.ID == route[i + 1]);
                }

                sum += FindLength(intstance1, instance2);
            }

            return sum;
        }

        public double CalculateDistanceValueForAllRouteWithVehicles(List<Instance> dataset, List<List<int>> route)
        {
            double sum = 0;

            for (int i = 0; i < route.Count; i++)
            {
                for (int j = 0; j < route[i].Count; j++)
                {
                    var intstance1 = dataset.FirstOrDefault(item => item.ID == route[i][j]);
                    Instance instance2;
                    if (j + 1 == route[i].Count)
                    {
                        instance2 = dataset.FirstOrDefault(item => item.ID == route[i][0]);
                    }
                    else
                    {
                        instance2 = dataset.FirstOrDefault(item => item.ID == route[i][j + 1]);
                    }

                    sum += FindLength(intstance1, instance2);
                }
            }

            return sum;
        }

        public string GetRouteInfo(List<int> route)
        {
            string strToShow = string.Empty;

            double time = 0.0;

            for(int i = 0; i < route.Count; i++)
            {
                var instance1 = dataset.FirstOrDefault(item => item.ID == route[i]);
                Instance instance2;
                if (i + 1 == route.Count)
                {
                    instance2 = dataset.FirstOrDefault(item => item.ID == route[0]);
                }
                else
                {
                    instance2 = dataset.FirstOrDefault(item => item.ID == route[i + 1]);
                }

                double length = FindLength(instance1, instance2);

                strToShow += "\nCurrent point: " + instance1.ID + " with capacity " + instance1.Demand + "\n";
                strToShow += "Ready time: " + instance1.ReadyTime + " Due time: " + instance1.DueTime + " Service time: " + instance1.ServiceTime;
                strToShow += "\nDistance to next point: " + length;
                strToShow += " Current time: " + time + "\n";

                time += length + instance2.ServiceTime;
            }

            return strToShow;
        }
    }
}
