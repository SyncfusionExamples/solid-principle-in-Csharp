using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID101.ISP
{
    public class InStoreOrder : IOrder, IOrderProcessing, ILabelPrinter
    {
        // Implementation of required methods

        public void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        
        public void CancelOrder()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder()
        {
            throw new NotImplementedException();
        }

        public void PrintLabel()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
