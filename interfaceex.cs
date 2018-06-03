using System;

namespace Testability
{
    class Program
    {
        static void Main(string[] args){
            var orderProcessor = new orderProcessor();
            var order = new Order{DatePlaced = DateTime.now, TotalPrice = 100f};
            orderProcessor.Process(order)
        }
    }
}