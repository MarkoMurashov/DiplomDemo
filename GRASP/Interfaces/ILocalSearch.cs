using GRASP.Models;
using System.Collections.Generic;

namespace GRASP.Interfaces
{
    interface ILocalSearch
    {
        List<List<int>> Run(List<Instance> dataset, List<List<int>> currentRoute,
            IEvaluator evaluator, IDistanceCalculator distanceCalculator, IPenaltyCalculator penaltyCalculator);
    }
}
