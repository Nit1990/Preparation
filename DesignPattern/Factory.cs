namespace DesignPattern
{

    // Product interface    
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }

    // Concrete products
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment of ${amount}");
            // Implement credit card payment processing logic
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
            // Implement PayPal payment processing logic
        }
    }

    // Creator interface(Factory Method)
    public interface IPaymentProcessorFactory
    {
        IPaymentProcessor CreatePaymentProcess();
    }

    // Concrete creator ( Concrete Factories)
    public class CreditClassProcessorFactory : IPaymentProcessorFactory
    {
        public IPaymentProcessor CreatePaymentProcess()
        {
            return new CreditCardProcessor();
        }
    }

    // CLient code 
    public class PaymentProcessorCLient
    {
        private IPaymentProcessorFactory paymentProcessorFactory;

        public PaymentProcessorCLient(IPaymentProcessorFactory factory)
        {
            this.paymentProcessorFactory = factory;
        }

        public void ProcessPayment(double amount)
        {
            IPaymentProcessor paymentProcessor = paymentProcessorFactory.CreatePaymentProcess();
            paymentProcessor.ProcessPayment(amount);
        }

    }

    // Main Code

    public class FactoryExample
    {
        public FactoryExample()
        {
            // Based on user input or configuration, decide which payment method to use
            IPaymentProcessorFactory creditcardFactory = new CreditClassProcessorFactory();

            // Client code dynamically chooses the payment method

            PaymentProcessorCLient client = new PaymentProcessorCLient(creditcardFactory);
            client.ProcessPayment(100.00);

        }
    }
}