IPayment creditCardProcessor = new CreditCardProcessor();
PaymentService paymentService = new PaymentService(creditCardProcessor);
paymentService.ProcessOrderPayment(100.0m);

IPayment paypalProcessor = new PaypalProcessor();
paymentService = new PaymentService(paypalProcessor);
paymentService.ProcessOrderPayment(20.0m);
public interface IPayment
{
    void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Credit card payment " + amount);
    }
}

public class PaypalProcessor : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Paypal payment "  + amount); 
    }
}

public class PaymentService
{
    private readonly IPayment _processor;
    public PaymentService(IPayment processor)
    {
        _processor = processor;
    }

    public void ProcessOrderPayment(decimal amount)
    {
        _processor.ProcessPayment(amount);
    }
}