using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilder
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}");
        }
    }
}
