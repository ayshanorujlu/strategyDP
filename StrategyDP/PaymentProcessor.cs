using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public class PaymentProcessor
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentProcessor(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
