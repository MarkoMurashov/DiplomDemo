using GRASP.Interfaces;
using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Business_logic
{
    class LocalSearchTwoOpt: ILocalSearch
    {
        public List<List<int>> Run(List<Instance> dataset, List<List<int>> currentRoute,
            IEvaluator evaluator, IDistanceCalculator distanceCalculator, IPenaltyCalculator penaltyCalculator)
        {
            int k = 0;
            while (k < 50)
            {
                var oldRouteBeforeLocalSearch = GRASPHelper.CopySolution(currentRoute);
                for (int g = 0; g < currentRoute.Count; g++)
                {
                    for (int i = 1; i < currentRoute[g].Count - 2; i++)
                    {
                        for (int j = i + 1; j < currentRoute[g].Count; j++)
                        {
                            double oldRouteQuality = evaluator.EvaluateRoute(dataset, currentRoute[g], distanceCalculator, penaltyCalculator);

                            var newRoute = twoOptSwap(currentRoute[g], i, j);

                            double newRouteQuality = evaluator.EvaluateRoute(dataset, newRoute, distanceCalculator, penaltyCalculator);

                            if (newRouteQuality < oldRouteQuality && evaluator.CanExistWithCurrentTimeWindows(dataset, newRoute, distanceCalculator))
                            {
                                currentRoute[g] = newRoute;
                            }
                        }
                    }
                }

                if (evaluator.isRoutesSame(currentRoute, oldRouteBeforeLocalSearch))
                {
                    break;
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

    }
}
