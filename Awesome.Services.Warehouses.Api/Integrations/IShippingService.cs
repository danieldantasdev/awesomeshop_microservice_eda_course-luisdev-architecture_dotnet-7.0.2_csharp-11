using Awesome.Services.Warehouses.Api.Events;

namespace Awesome.Services.Warehouses.Api.Integrations;

public interface IShippingService
{
    void ShipOrder(OrderCreatedEvent @event);
}