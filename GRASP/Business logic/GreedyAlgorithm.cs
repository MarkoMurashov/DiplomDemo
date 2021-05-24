using GRASP.Interfaces;
using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Business_logic
{
    class GreedyAlgorithm: IGreedyAlgorithm
    {
        private List<Instance> dataset;

        private IDistanceCalculator distanceCalculator;

        private IEvaluator evaluator;

        public GreedyAlgorithm(List<Instance> dataset, IDistanceCalculator distanceCalculator, IEvaluator evaluator)
        {
            this.dataset = dataset;
            this.distanceCalculator = distanceCalculator;
            this.evaluator = evaluator;
        }



        public List<int> Run(float vehicleCapacity, List<float> currentVehicleCapasity, int currentVehicleIndex, double alpha = 0.2)
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
                    var distDict = distanceCalculator.CalculateDistance(dataset, startPoint);

                    if (distDict.Count == 0)
                        break;

                    double cMin = distDict.Min(x => x.Value);

                    double cMax = distDict.Max(x => x.Value);

                    double criteria = cMin + alpha * (cMax - cMin);
                    double demandCriteria = vehicleCapacity - currentVehicleCapasity[currentVehicleIndex];

                    var listWithGoodPoints = new List<Instance>();
                    foreach (var dist in distDict)
                    {
                        var tmp_inst = dataset.FirstOrDefault(item => item.ID == dist.Key);

                        double futureTime = currentTime + dist.Value;
                        bool timeWindowCriteria = (futureTime < tmp_inst.DueTime + Parameters.SOFT_DUE_WINDOW);

                        if (dist.Value <= criteria && tmp_inst.Demand <= demandCriteria && timeWindowCriteria)
                        {
                            listWithGoodPoints.Add(tmp_inst);
                        }
                    }

                    var RCL = new HashSet<int>();
                    foreach (var point in listWithGoodPoints)
                    {
                        double cMinReadyTime = listWithGoodPoints.Min(x => x.ReadyTime);
                        double cMaxReadyTime = listWithGoodPoints.Max(x => x.ReadyTime);

                        double criteriaReadyTime = cMinReadyTime + 0.05 * (cMaxReadyTime - cMinReadyTime);

                        if (point.ReadyTime <= criteriaReadyTime)
                        {
                            RCL.Add(point.ID);
                        }
                    }

                    if (RCL.Count == 0)
                    {
                        break;
                    }
                    else
                    {
                        var prevStartPoint = dataset.FirstOrDefault(item => item.ID == startPoint);

                        Random random = new Random();
                        startPoint = RCL.ElementAt(random.Next(RCL.Count));

                        var inst = dataset.FirstOrDefault(item => item.ID == startPoint);
                        currentVehicleCapasity[currentVehicleIndex] += inst.Demand;

                        float dist = (float)distanceCalculator.FindLength(inst, prevStartPoint);

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
            } while (!evaluator.CanExistWithCurrentTimeWindows(dataset, route, distanceCalculator) || route.Count <= 2);

            return route;
        }
    }
}
