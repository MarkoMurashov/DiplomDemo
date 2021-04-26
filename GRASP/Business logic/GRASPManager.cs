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
            for (int z = 0; z < vehicleCount; z++)
            {
                initialResult.Add(GreedyAlgorithm(dataset, z));
            }            
            var bestSolution = initialResult;
            var currentRoute = initialResult;

            //int iterator = 0;
            //while (iterator < 5 || currentVehicleCapasity.All(vehicle => vehicle == vehicleCapacity))
            //{
            //    if (iterator != 0)
            //    {
            //        ResetDataset(dataset);
            //        currentRoute = GreedyAlgorithm(dataset);
            //    }                

            //    int k = 0;
            //    while (k < 5)
            //    {
            //        var oldRouteBeforeLocalSearch = currentRoute;
            //        for (int i = 1; i < currentRoute.Count - 2; i++)
            //        {
            //            for (int j = i + 1; j < currentRoute.Count; j++)
            //            {
            //                double oldDistance = CalculateDistanceValueForAllRoute(dataset, currentRoute);

            //                var newRoute = twoOptSwap(currentRoute, i, j);
            //                double newDistance = CalculateDistanceValueForAllRoute(dataset, newRoute);

            //                if (newDistance < oldDistance)
            //                {
            //                    currentRoute = newRoute;
            //                }
            //            }
            //        }

            //        if(isRoutesSame(currentRoute, oldRouteBeforeLocalSearch))
            //        {
            //            break;
            //        }
            //        k++;
            //    }

            //    double oldDist = CalculateDistanceValueForAllRoute(dataset, bestSolution);
            //    double currentDist= CalculateDistanceValueForAllRoute(dataset, currentRoute);
            //    if (currentDist < oldDist)
            //    {
            //        bestSolution = currentRoute;
            //    }
            //    iterator++;
            //}

            return bestSolution;
        }

        private bool isRoutesSame(List<int> route1, List<int> route2)
        {
            for(int i = 0; i < route1.Count; i++)
            {
                if(route1[i] != route2[i])
                {
                    return false;
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
