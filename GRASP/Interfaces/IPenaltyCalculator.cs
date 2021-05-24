using GRASP.Models;
using System.Collections.Generic;

namespace GRASP.Interfaces
{
    interface IPenaltyCalculator
    {
        void CalculatePenalties(List<Instance> dataset, List<int> newRoute, IDistanceCalculator distanceCalculator, out double latePenalty, out double waitPenalty);

        void CalculatePenaltiesForAllRoute(List<Instance> dataset, List<List<int>> newRoute, IDistanceCalculator distanceCalculator, out double latePenaltyGlobal, out double waitPenaltyGlobal);
    }
}
