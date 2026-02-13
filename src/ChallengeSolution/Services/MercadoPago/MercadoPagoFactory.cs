namespace ChallengeSolution.Services.MercadoPago;

internal class MercadoPagoFactory : IPaymentGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new MercadoPagoProcessor();
    public IPaymentValidator CreatePaymentValidator() => new MercadoPagoValidator();
    public IPaymentLogger CreatePaymentLogger() => new MercadoPagoLogger();
}
