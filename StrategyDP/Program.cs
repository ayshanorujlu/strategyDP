using StrategyDP;

var paymentProcessor = new PaymentProcessor(new CreditCardPaymentStrategy());
paymentProcessor.ProcessPayment(100.00m);


paymentProcessor = new PaymentProcessor(new PayPalPaymentStrategy());
paymentProcessor.ProcessPayment(100.00m);
