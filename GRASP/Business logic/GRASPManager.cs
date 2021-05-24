using GRASP.Interfaces;
using GRASP.Models;
using System.Collections.Generic;
using System.Linq;

namespace GRASP.Business_logic
{
    public class GRASPManager
    {
        #region private fields

        private float vehicleCapacity;

        private int vehicleCount;

        private List<float> currentVehicleCapasity;

        private List<Instance> dataset;

        private IGreedyAlgorithm greedyAlgorithm;

        private IDistanceCalculator distanceCalculator;

        private IEvaluator evaluator;

        private IPenaltyCalculator penaltyCalculator;

        private ILocalSearch localSearchTwoOpt;

        private ILocalSearch localSearchSwap;

        #endregion

        public GRASPManager(List<Instance> dataset, int vehicleCount, float vehicleCapacity)
        {
            this.vehicleCapacity = vehicleCapacity;
            this.vehicleCount = vehicleCount;
            this.dataset = dataset;
            InitVehicleCapacityAndTW();

            distanceCalculator = new DistanceCalculator();
            evaluator = new Evaluator();
            greedyAlgorithm = new GreedyAlgorithm(dataset, distanceCalculator, evaluator);
            penaltyCalculator = new PenaltyCalculator();
            localSearchTwoOpt = new LocalSearchTwoOpt();
            localSearchSwap = new LocalSearchSwap();
        }

        #region private methods

        private void InitVehicleCapacityAndTW()
        {
            currentVehicleCapasity = new List<float>();
            for (int i = 0; i < vehicleCount; i++)
            {
                currentVehicleCapasity.Add(0);
            }
        }

        private void ResetCapacityAndTime()
        {
            for (int i = 0; i < vehicleCount; i++)
            {
                currentVehicleCapasity[i] = 0;
            }
        }
     
        private void ResetDataset()
        {
            for (int i = 0; i < dataset.Count; i++)
            {
                this.dataset[i].IsDone = false;
            }
        }
          
        #endregion

        public List<List<int>> Execute(bool withSwap = false)
        {
            ResetDataset();
            ResetCapacityAndTime();

            var initialResult = new List<List<int>>();
            for (int z = 0; z < vehicleCount && !dataset.All(item => item.IsDone); z++)
            {
                initialResult.Add(greedyAlgorithm.Run(vehicleCapacity, currentVehicleCapasity, z));
            }
            var bestSolution = GRASPHelper.CopySolution(initialResult);
            var currentRoute = GRASPHelper.CopySolution(initialResult);

            int iterator = 0;
            while (iterator < Parameters.MAX_GRASP_ITERATION)
            {
                if (iterator != 0)
                {
                    ResetDataset();
                    ResetCapacityAndTime();
                    currentRoute.Clear();
                    for (int z = 0; z < vehicleCount && !dataset.All(item => item.IsDone); z++)
                    {
                        currentRoute.Add(greedyAlgorithm.Run(vehicleCapacity, currentVehicleCapasity, z));
                    }
                }

                var tmp_route = localSearchTwoOpt.Run(dataset, currentRoute, evaluator, distanceCalculator, penaltyCalculator);

                if (withSwap)
                {
                    tmp_route = GRASPHelper.CopySolution(localSearchSwap.Run(dataset, currentRoute, evaluator, distanceCalculator, penaltyCalculator));
                }

                double oldQuality = evaluator.EvaluateGlobalRoute(dataset, bestSolution, distanceCalculator, penaltyCalculator);
                double currentQuality = evaluator.EvaluateGlobalRoute(dataset, tmp_route, distanceCalculator, penaltyCalculator);
               
                if (currentQuality < oldQuality)
                {
                    bestSolution = GRASPHelper.CopySolution(tmp_route);
                    currentRoute = GRASPHelper.CopySolution(tmp_route);
                }
                iterator++;
            }

            return bestSolution;
        }

        public double CalculateDistance(List<List<int>> route)
        {
           return distanceCalculator.CalculateDistanceValueForAllRouteWithVehicles(dataset, route);
        }

        public string GetInfo(List<int> route)
        {
            return new Visualizer().GetRouteInfo(dataset, route, distanceCalculator);
        }

    }
}
