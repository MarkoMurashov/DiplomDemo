using GRASP.Interfaces;
using GRASP.Models;
using System.Collections.Generic;
using System.Linq;

namespace GRASP.Business_logic
{
    class Visualizer
    {

        public string GetRouteInfo(List<Instance> dataset, List<int> route, IDistanceCalculator distanceCalculator)
        {
            string strToShow = string.Empty;

            double time = 0.0;

            for (int i = 0; i < route.Count; i++)
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

                double length = distanceCalculator.FindLength(instance1, instance2);

                strToShow += "\nCurrent point: " + instance1.ID + " with capacity " + instance1.Demand + "\n";
                strToShow += "Ready time: " + instance1.ReadyTime + " Due time: " + instance1.DueTime + " Service time: " + instance1.ServiceTime;
                strToShow += "\nDistance to next point: " + length;
                strToShow += " Current time: " + time + "\n";

                double futureTime = time + length + instance2.ServiceTime;
                if (futureTime < instance2.ReadyTime)
                {
                    time = instance2.ReadyTime;
                }
                else
                {
                    time += length + instance2.ServiceTime;
                }
            }

            return strToShow;
        }
    }
}
