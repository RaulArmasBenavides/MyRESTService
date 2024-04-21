using MyRESTService.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcfrestservice.erpmak.entity.Interfaces
{
    public interface IComputerBuilder
    {
        void BuildCPU();
        void BuildGPU();
        void BuildMemory();
        Computer GetComputer();
    }
}
