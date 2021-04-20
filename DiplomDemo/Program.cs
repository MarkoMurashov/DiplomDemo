using DiplomDemo.Business_logic;
using System;
using System.Linq;
using System.Net.WebSockets;

namespace DiplomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileReader = new FileReader();
            //var dataset = fileReader.Read("dataset.txt");
            var dataset = fileReader.Read("small test.txt");

            Visualizer.Visulize(dataset);

            var grasp = new GRASPManager();
            var tmp = grasp.Execute(dataset);
            Console.WriteLine();
            Console.WriteLine("Result:");
            foreach (var point in tmp)
            {
                Console.Write ($"{point}\t");
            }

            Console.WriteLine();
            Console.WriteLine($"Count: {tmp.Count}");
            Console.WriteLine($"Count of unique:  {tmp.Distinct().Count()}");
            Console.WriteLine($"Dist:  {grasp.CalculateDistanceValueForAllRoute(dataset, tmp)}");

            Console.ReadLine();
        }
    }
}
