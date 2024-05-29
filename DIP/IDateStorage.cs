using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID101.DIP
{
    public interface IDataStorage
    {
        // Define the contract for data storage operations
        void SaveData(string data);
        string RetrieveData();
    }
}
