using GRASP.Models;
using System.Collections.Generic;

namespace GRASP.Interfaces
{
    interface IDistanceCalculator
    {
        double FindLength(Instance instance1, Instance instance2);

        Dictionary<int, double> CalculateDistance(List<Instance> dataset, int startPoint);

        double CalculateDistanceValueForAllRouteWithVehicles(List<Instance> dataset, List<List<int>> route);

        double CalculateDistanceValueForAllRoute(List<Instance> dataset, List<int> route);
    }
}
