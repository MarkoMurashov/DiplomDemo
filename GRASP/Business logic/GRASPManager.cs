using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Business_logic
{
    public class GRASPManager
    {
        private float vehicleCapacity;

        private int vehicleCount;

        private List<float> currentVehicleCapasity;

        public GRASPManager(int vehicleCount, float vehicleCapacity)
        {
            this.vehicleCapacity = vehicleCapacity;
            this.vehicleCount = vehicleCount;
            InitVehicleCapacity();
        }

        private void InitVehicleCapacity()
        {
            currentVehicleCapasity = new List<float>();
            for (int i = 0; i < vehicleCount; i++)
            {
                currentVehicleCapasity.Add(0);
            }
        }

        public List<List<int>> Execute(List<Instance> dataset, out List<List<int>> initialResult, double alpha = 0.2)
        {
            initialResult = new List<List<int>>();
            for (int z = 0; z < vehicleCount && !dataset.All(item => item.IsDone); z++)
            {
                initialResult.Add(GreedyAlgorithm(dataset, z));
            }            
            var bestSolution = CopySolution(initialResult);
            var currentRoute = CopySolution(initialResult);

            int iterator = 0;
            while (iterator < 15)
            {
                if (iterator != 0)
                {
                    ResetDataset(dataset);
                    ResetCapacity();
                    currentRoute.Clear();
                    for (int z = 0; z < vehicleCount && !dataset.All(item => item.IsDone); z++)
                    {
                        currentRoute.Add(GreedyAlgorithm(dataset, z));
                    }
                }

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
                                double oldDistance = CalculateDistanceValueForAllRoute(dataset, currentRoute[g]);

                                var newRoute = twoOptSwap(currentRoute[g], i, j);
                                double newDistance = CalculateDistanceValueForAllRoute(dataset, newRoute);

                                if (newDistance < oldDistance)
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

                double oldDist = CalculateDistanceValueForAllRouteWithVehicles(dataset, bestSolution);
                double currentDist = CalculateDistanceValueForAllRouteWithVehicles(dataset, currentRoute);
                if (currentDist < oldDist)
                {
                    bestSolution = CopySolution(currentRoute);
                }
                iterator++;
            }

            return bestSolution;
        }


        private List<List<int>> CopySolution(List<List<int>> route)
        {
            List<List<int>> newList = new List<List<int>>();
            foreach(var item in route)
            {
                List<int> tmp = new List<int>();
                foreach(int num in item)
                {
                    tmp.Add(num);
                }
                newList.Add(tmp);
            }

            return newList;
        }

        private void ResetCapacity()
        {
            for (int i = 0; i < vehicleCount; i++)
                currentVehicleCapasity[i] = 0;
        }

        private bool isRoutesSame(List<List<int>> route1, List<List<int>> route2)
        {
            for(int i = 0; i < route1.Count; i++)
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

        public double CalculateDistanceValueForAllRoute(List<Instance> dataset, List<int> route)
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
                for(int j = 0; j < route[i].Count; j++)
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

        private void ResetDataset(List<Instance> dataset)
        {
            for (int i = 0; i < dataset.Count; i++)
            {
                dataset[i].IsDone = false;
            }
        }

        private List<int> GreedyAlgorithm(List<Instance> dataset, int currentVehicleIndex, double alpha = 0.2)
        {
            var route = new List<int>();
            int startPoint = 0;

            route.Add(startPoint);
            dataset.FirstOrDefault(item => item.ID == startPoint).IsDone = true;

            while (!dataset.All(item => item.IsDone))
            {
                var distDict = CalculateDistance(dataset, startPoint);

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
                    float capacity = dataset.FirstOrDefault(item => item.ID == dist.Key).Demand;
                    if (dist.Value <= criteria && capacity <= demandCriteria)
                    {
                        RCL.Add(dist.Key);
                    }
                }
               
                if(RCL.Count == 0)
                {
                    break;
                }
                else
                {
                    startPoint = RCL.ElementAt(random.Next(RCL.Count));
                    var inst = dataset.FirstOrDefault(item => item.ID == startPoint);
                    currentVehicleCapasity[currentVehicleIndex] += inst.Demand;
                    route.Add(startPoint);

                    dataset.FirstOrDefault(item => item.ID == startPoint).IsDone = true;
                }               
            }
            route.Add(0);

            return route;
        }
        
        private Dictionary<int, double> CalculateDistance(List<Instance> dataset, int startPoint)
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
    }
}
