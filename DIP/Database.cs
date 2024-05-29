using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID101.DIP
{
    public class Database : IDataStorage
    {
        public void SaveData(string data)
        {
            // Implementation for saving data to a database
        }

        public string RetrieveData()
        {
            // Implementation for retrieving data from a database

            return string.Empty;
        }
    }
}
