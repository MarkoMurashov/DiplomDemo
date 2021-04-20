using DiplomDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiplomDemo.Business_logic
{
    public class Visualizer
    {
        public static void Visulize(List<Instance> instances)
        {
            foreach(var instance in instances)
            {
                Console.WriteLine($"ID:  {instance.ID}   X:   {instance.X}  Y:    {instance.Y}");
            }
        }
    }
}
