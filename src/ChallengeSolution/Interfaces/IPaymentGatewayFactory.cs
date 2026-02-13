public interface IPaymentGatewayFactory
{
    IPaymentProcessor CreatePaymentProcessor();
    IPaymentValidator CreatePaymentValidator();
    IPaymentLogger CreatePaymentLogger();
}
