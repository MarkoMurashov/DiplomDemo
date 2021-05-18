using GRASP.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace GRASP.Business_logic
{
    public class FileReader
    {
        public List<Instance> Read(string path)
        {
            var instances = new List<Instance>();

            foreach (var line in File.ReadLines(path))
            {
                try
                {
                    var values = line.Split(' ').Where(s => !string.IsNullOrEmpty(s)).ToArray();
                    int id = int.Parse(values[0]);
                    float x = float.Parse(values[1], CultureInfo.InvariantCulture.NumberFormat);
                    float y = float.Parse(values[2], CultureInfo.InvariantCulture.NumberFormat);
                    float demand = float.Parse(values[3], CultureInfo.InvariantCulture.NumberFormat);
                    float readyTime = float.Parse(values[4], CultureInfo.InvariantCulture.NumberFormat);
                    float dueTime = float.Parse(values[5], CultureInfo.InvariantCulture.NumberFormat);
                    float serviceTime = float.Parse(values[6], CultureInfo.InvariantCulture.NumberFormat);

                    instances.Add(new Instance { ID = id, X = x, Y = y, Demand = demand, ReadyTime = readyTime, DueTime = dueTime, ServiceTime = serviceTime, IsDone = false });
                }
                catch (FormatException)
                {
                    throw new FormatException("Данные в неправильном формате!");
                }
            }

            return instances;
        }
    }
}
