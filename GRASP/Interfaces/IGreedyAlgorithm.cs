using System;
using System.Collections.Generic;

namespace GRASP.Interfaces
{
    interface IGreedyAlgorithm
    {
        List<int> Run(float vehicleCapacity, List<float> currentVehicleCapasity, int currentVehicleIndex);
    }
}
