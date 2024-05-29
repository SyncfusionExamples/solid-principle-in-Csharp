using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID101.DIP
{
    public class UserController
    {
        private IDataStorage dataStorage;

        public UserController(IDataStorage dataStorage)
        {
            this.dataStorage = dataStorage;
        }

        // Implement the flow as you need...
    }
}
