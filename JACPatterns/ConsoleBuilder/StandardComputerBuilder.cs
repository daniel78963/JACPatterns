using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilder
{
    public class StandardComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();
        public void BuildCPU()
        {
            computer.CPU = "Intel Core i7";
        }

        public void BuildRAM()
        {
            computer.RAM = "8GB";
        }

        public void BuildStorage()
        {
            computer.Storage = "256GB SSD";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
