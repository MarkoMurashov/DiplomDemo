using GRASP.Models;
using System.Collections.Generic;

namespace GRASP.Interfaces
{
    interface IEvaluator
    {
        bool CanExistWithCurrentTimeWindows(List<Instance> dataset, List<int> newRoute, IDistanceCalculator distanceCalculator);

        double EvaluateGlobalRoute(List<Instance> dataset, List<List<int>> newRoute, IDistanceCalculator distanceCalculator, IPenaltyCalculator penaltyCalculator);

        double EvaluateRoute(List<Instance> dataset, List<int> route, IDistanceCalculator distanceCalculator, IPenaltyCalculator penaltyCalculator);

        bool isRoutesSame(List<List<int>> route1, List<List<int>> route2);
    }
}
