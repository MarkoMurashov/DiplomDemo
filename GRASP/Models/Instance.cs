using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Models
{
    public class Instance
    {
        public int ID { get; set; }

        public float X { get; set; }

        public float Y { get; set; }

        public float Demand { get; set; }

        public bool IsDone { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}\n X: {X}\n Y: {Y}\nDemand: {Demand}";
        }
    }
}
