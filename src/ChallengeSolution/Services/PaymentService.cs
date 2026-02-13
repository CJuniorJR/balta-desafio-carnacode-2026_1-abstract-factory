namespace ChallengeSolution.Services;

public class PaymentService
{
    private readonly IPaymentGatewayFactory _paymentFactory;
    private readonly IPaymentLogger _logger;
    private readonly IPaymentValidator _validator;
    private readonly IPaymentProcessor _processor;

    public PaymentService(IPaymentGatewayFactory paymentFactory)
    {
        _paymentFactory = paymentFactory;
        _logger = _paymentFactory.CreatePaymentLogger();
        _validator = _paymentFactory.CreatePaymentValidator();
        _processor = _paymentFactory.CreatePaymentProcessor();
    }

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        if (!_validator.ValidateCard(cardNumber))
        {
            _logger.Log("Cartão inválido");
            return;
        }

        var processMessage = _processor.ProcessTransaction(amount, cardNumber);
        _logger.Log($"Transação processada: {processMessage}");
    }
}
