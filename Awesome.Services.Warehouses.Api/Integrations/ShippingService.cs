using Awesome.Services.Warehouses.Api.Events;

namespace Awesome.Services.Warehouses.Api.Integrations;

public class ShippingService : IShippingService
{
    public void ShipOrder(OrderCreatedEvent @event)
    {
        Console.WriteLine("Order is shipped");
    }
}