
using DesignPatternsApp.src.OopPrinciples.Coupling;

var order = new Order(new EmailSender());
order.PlaceOrder();
order = new Order(new SmsSender());
order.PlaceOrder();
