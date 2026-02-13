namespace ChallengeSolution.Services.Stripe;

public class StripeFactory : IPaymentGatewayFactory
{
    public IPaymentLogger CreatePaymentLogger() => new StripeLogger();

    public IPaymentProcessor CreatePaymentProcessor() => new StripeProcessor();

    public IPaymentValidator CreatePaymentValidator() => new StripeValidator();
}
