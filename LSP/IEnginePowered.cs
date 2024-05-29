using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID101.LSP
{
    public interface IEnginePowered
    {
        void StartEngine();
        void StopEngine();
    }
}
