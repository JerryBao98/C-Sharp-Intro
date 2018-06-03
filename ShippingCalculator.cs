namespace Testability
{
    public class ShippingCalculator{
        public float CalculateShipping(Order order){
            if (order.TotalPice < 30f){
                return order.TotalPice * 0.1f;
            }
            return 0;
        }
    }
}