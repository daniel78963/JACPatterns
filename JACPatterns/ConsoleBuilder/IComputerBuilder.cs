using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBuilder
{
    public interface IComputerBuilder
    {
        void BuildCPU();
        void BuildRAM();
        void BuildStorage();

        public Computer GetComputer();

    }
}
