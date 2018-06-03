using System;

namespace Testability
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _shippingCalclator;
    }
    public OrderProcessor(){
        _shippingCalclator = new ShippingCalculator();
    }
    
    public void Process (Order order)
    {
        if (order.isShipped){
            throw new InvalidOperationException("This order has already been shipped");
        }
        order.Shipment = new Shipment{
            Cost = _shippingCalclator.CalculateShipping(order),
            ShippingDate = DateTime.Today.AddDays(1)
        }
    }

}