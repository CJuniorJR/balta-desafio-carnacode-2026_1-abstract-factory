using ChallengeSolution.Services;
using ChallengeSolution.Services.MercadoPago;
using ChallengeSolution.Services.PagSeguro;
using ChallengeSolution.Services.Stripe;

Console.WriteLine("=== Sistema de Pagamentos ===\n");

var pagSeguroFactory = new PagSeguroFactory();
var pagSeguroService = new PaymentService(pagSeguroFactory);
pagSeguroService.ProcessPayment(150.00m, "1234567890123456");

Console.WriteLine();

var mercadoPagoFactory = new MercadoPagoFactory();
var mercadoPagoService = new PaymentService(mercadoPagoFactory);
mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");

Console.WriteLine();

var stripeFactory = new StripeFactory();
var StripeService = new PaymentService(stripeFactory);
StripeService.ProcessPayment(250.00m, "4234567890123456");
