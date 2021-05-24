using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Interfaces
{
    interface IGreedyAlgorithm
    {
        List<int> Run(float vehicleCapacity, List<float> currentVehicleCapasity, int currentVehicleIndex, double alpha = 0.2);
    }
}
