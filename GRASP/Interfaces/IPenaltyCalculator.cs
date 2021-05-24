using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Interfaces
{
    interface IPenaltyCalculator
    {
        void CalculatePenalties(List<Instance> dataset, List<int> newRoute, IDistanceCalculator distanceCalculator, out double latePenalty, out double waitPenalty);

        void CalculatePenaltiesForAllRoute(List<Instance> dataset, List<List<int>> newRoute, IDistanceCalculator distanceCalculator, out double latePenaltyGlobal, out double waitPenaltyGlobal);
    }
}
