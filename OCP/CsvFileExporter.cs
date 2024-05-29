using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID101.OCP
{
    public class CsvFileExporter : FileExporter
    {
        public override void Export(string filePath, DataTable data)
        {
            // Code logic to export data to a CSV file
        }
    }
}
