using GRASP.Interfaces;
using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Business_logic
{
    class LocalSearchSwap: ILocalSearch
    {

        public List<List<int>> Run(List<Instance> dataset, List<List<int>> currentRoute,
            IEvaluator evaluator, IDistanceCalculator distanceCalculator, IPenaltyCalculator penaltyCalculator)
        {
            int k = 0;
            while (k < 50)
            {
                var oldRouteBeforeLocalSearchCopy = GRASPHelper.CopySolution(currentRoute);
                double oldQuality = evaluator.EvaluateGlobalRoute(dataset, oldRouteBeforeLocalSearchCopy, distanceCalculator, penaltyCalculator);

                bool WasIpmroved = false;
                for (int g = 0; g < currentRoute.Count && !WasIpmroved; g++) //10  routes
                {
                    if (currentRoute[g].Count <= 2)
                        continue;

                    for (int z = 0; z < currentRoute.Count && !WasIpmroved; z++)
                    {
                        if (g == z)
                            continue;

                        //current route
                        for (int i = 1; i < currentRoute[g].Count && !WasIpmroved; i++) // 0 1 2 3 4 0 - 2
                        {
                            int pointFromDiffRoute = currentRoute[g][i];
                            //next route
                            for (int j = 1; j < currentRoute[z].Count && !WasIpmroved; j++)// 0 5 6 7 0
                            {
                                var tmp_copy = GRASPHelper.CopySolution(oldRouteBeforeLocalSearchCopy);

                                tmp_copy[z].Insert(j, pointFromDiffRoute); //0 1 5 6 7 0

                                if (!evaluator.CanExistWithCurrentTimeWindows(dataset, tmp_copy[z], distanceCalculator))
                                {
                                    continue;
                                }

                                tmp_copy[g].RemoveAt(i);//0 2 3 4 0
                                double localQuality = evaluator.EvaluateGlobalRoute(dataset, tmp_copy, distanceCalculator, penaltyCalculator);

                                if (localQuality < oldQuality)
                                {
                                    currentRoute = tmp_copy;
                                    WasIpmroved = true;
                                }

                            }
                        }
                    }
                }

                if (!WasIpmroved)
                {
                    break;
                }
                k++;
            }

            return currentRoute;
        }
    }
}
