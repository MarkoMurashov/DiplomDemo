using GRASP.Interfaces;
using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GRASP.Business_logic
{
    class DistanceCalculator: IDistanceCalculator
    {

        public Dictionary<int, double> CalculateDistance(List<Instance> dataset, int startPoint)
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

        public double FindLength(Instance instance1, Instance instance2)
                 => Math.Sqrt(Math.Pow((instance1.X - instance2.X), 2) + Math.Pow((instance1.Y - instance2.Y), 2));

    }
}
