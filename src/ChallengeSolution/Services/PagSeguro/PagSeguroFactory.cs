namespace ChallengeSolution.Services.PagSeguro;

public class PagSeguroFactory : IPaymentGatewayFactory
{
    public IPaymentLogger CreatePaymentLogger() => new PagSeguroLogger();

    public IPaymentProcessor CreatePaymentProcessor() => new PagSeguroProcessor();

    public IPaymentValidator CreatePaymentValidator() => new PagSeguroValidator();
}
