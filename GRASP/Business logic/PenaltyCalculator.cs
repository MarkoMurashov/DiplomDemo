using GRASP.Interfaces;
using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Business_logic
{
    class PenaltyCalculator: IPenaltyCalculator
    {

        public void CalculatePenalties(List<Instance> dataset, List<int> newRoute, IDistanceCalculator distanceCalculator, out double latePenalty, out double waitPenalty)
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

                double currDist = distanceCalculator.FindLength(intstance1, instance2);


                double futureTime = currentTime + currDist;

                if (futureTime > instance2.DueTime && futureTime < (instance2.DueTime + Parameters.SOFT_DUE_WINDOW))
                {
                    latePenalty += futureTime - instance2.DueTime;
                }

                if (futureTime < instance2.ReadyTime)
                {
                    waitPenalty += instance2.ReadyTime - currentTime;
                }
            }
        }

        public void CalculatePenaltiesForAllRoute(List<Instance> dataset, List<List<int>> newRoute, IDistanceCalculator distanceCalculator, out double latePenaltyGlobal, out double waitPenaltyGlobal)
        {
            waitPenaltyGlobal = 0.0;
            latePenaltyGlobal = 0.0;

            foreach (var route in newRoute)
            {
                CalculatePenalties(dataset, route, distanceCalculator, out double latePenaltyLocal, out double waitPenaltyLocal);
                waitPenaltyGlobal += waitPenaltyLocal;
                latePenaltyGlobal += latePenaltyLocal;
            }
        }
    }
}
