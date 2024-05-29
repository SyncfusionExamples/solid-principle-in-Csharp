using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID101.OCP
{
    public abstract class FileExporter
    {
        public abstract void Export(string filePath, DataTable data);
    }
}
