using System;

namespace OnlineBakeryOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = BakeryOrder.CreateOrder("Todd", "118 W Smith St, Seattle, WA, 98119", "test@test.com","12345678910",1);
            Console.WriteLine($"Menu:{a1.Bread}, IP:{a1.ItemPrice}, CN: {a1.CustomerNumber}, D:{a1.Date}");
            var a2 = BakeryOrder.CreateOrder("Ivan", "5235, 22nd Ave NE, Seattle, WA, 98105", "test1@test.com","10987654321",2);
            Console.WriteLine($"Menu:{a2.Bread}, IP:{a2.ItemPrice}, CN: {a2.CustomerNumber}, D:{a1.Date}");

        }
    }
}
