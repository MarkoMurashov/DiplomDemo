using GRASP.Interfaces;
using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Business_logic
{
    class Evaluator: IEvaluator
    {

        public bool CanExistWithCurrentTimeWindows(List<Instance> dataset, List<int> newRoute, IDistanceCalculator distanceCalculator)
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

                double currDist = distanceCalculator.FindLength(intstance1, instance2);


                double futureTime = currentTime + currDist;
                bool timeWindowCriteria = (futureTime < (instance2.DueTime + Parameters.SOFT_DUE_WINDOW));

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

        public double EvaluateGlobalRoute(List<Instance> dataset, List<List<int>> newRoute, IDistanceCalculator distanceCalculator, IPenaltyCalculator penaltyCalculator)
        {
            penaltyCalculator.CalculatePenaltiesForAllRoute(dataset, newRoute, distanceCalculator, out double latePenaltyGlobal, out double waitPenaltyGlobal);

            double dist = distanceCalculator.CalculateDistanceValueForAllRouteWithVehicles(dataset, newRoute);

            return dist + latePenaltyGlobal + waitPenaltyGlobal * Parameters.COEF_WAIT_PENALTY;
        }

        public double EvaluateRoute(List<Instance> dataset, List<int> route, IDistanceCalculator distanceCalculator, IPenaltyCalculator penaltyCalculator)
        {
            double dist = distanceCalculator.CalculateDistanceValueForAllRoute(dataset, route);

            penaltyCalculator.CalculatePenalties(dataset, route, distanceCalculator, out double latePenalty, out double waitPenalty);

            return dist + latePenalty + waitPenalty * Parameters.COEF_WAIT_PENALTY;
        }

        public bool isRoutesSame(List<List<int>> route1, List<List<int>> route2)
        {
            for (int i = 0; i < route1.Count; i++)
            {
                if (route1[i].Count != route2[i].Count)
                    return false;

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
    }
}
