using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID101.ISP
{
    public class OnlineOrder : IOrder, IOrderProcessing, IInvoiceGenerator, IEmailSender
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

        public void GenerateInvoice()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder()
        {
            throw new NotImplementedException();
        }

        public void SendConfirmationEmail()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
