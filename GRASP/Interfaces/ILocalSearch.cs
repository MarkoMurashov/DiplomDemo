using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Interfaces
{
    interface ILocalSearch
    {
        List<List<int>> Run(List<Instance> dataset, List<List<int>> currentRoute,
            IEvaluator evaluator, IDistanceCalculator distanceCalculator, IPenaltyCalculator penaltyCalculator);
    }
}
