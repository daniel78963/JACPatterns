using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilder
{
    class ComputerDirector
    {
        private IComputerBuilder builder;
        public ComputerDirector(IComputerBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildComputer()
        {
            builder.BuildCPU();
            builder.BuildRAM();
           builder.BuildStorage();
        }
    }
}
