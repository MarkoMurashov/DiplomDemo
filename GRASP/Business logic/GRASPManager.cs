using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Business_logic
{
    public class GRASPManager
    {
        public List<int> Execute(List<Instance> dataset, out List<int> initialResult, double alpha = 0.2)
        {
            initialResult = GreedyAlgorithm(dataset);

            Console.WriteLine("Result:");
            foreach (var point in initialResult)
            {
                Console.Write($"{point}\t");
            }
            Console.WriteLine("Dist   " + CalculateDistanceValueForAllRoute(dataset, initialResult));

            var currentRoute = initialResult;

            int k = 0;
            while (k < 5)
            {
                for (int i = 1; i < initialResult.Count - 2; i++)
                {
                    for (int j = i + 2; j < initialResult.Count; j++)
                    {
                        double oldDistance = CalculateDistanceValueForAllRoute(dataset, currentRoute);

                        var newRoute = twoOptSwap(currentRoute, i, j);
                        double newDistance = CalculateDistanceValueForAllRoute(dataset, newRoute);

                        if (newDistance < oldDistance)
                        {
                            currentRoute = newRoute;
                        }
                    }
                }
                k++;
            }
            return currentRoute;
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

        private List<int> GreedyAlgorithm(List<Instance> dataset, double alpha = 0.2)
        {
            var route = new List<int>();
            int startPoint = 0;

            route.Add(startPoint);

            while (!dataset.All(item => item.IsDone))
            {
                var distDict = CalculateDistance(dataset, startPoint);

                if (distDict.Count == 0)
                    break;

                double cMin = distDict.Min(x => x.Value);

                double cMax = distDict.Max(x => x.Value);

                double criteria = cMin + 0.2 * (cMax - cMin);

                Random random = new Random();

                var RCL = new HashSet<int>();
                foreach (var dist in distDict)
                {
                    if (dist.Value <= criteria)
                    {
                        RCL.Add(dist.Key);
                    }
                }

                dataset.FirstOrDefault(item => item.ID == startPoint).IsDone = true;

                startPoint = RCL.ElementAt(random.Next(RCL.Count));
                route.Add(startPoint);
            }

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
