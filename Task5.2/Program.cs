using System;
using System.Collections.Generic;

namespace Task5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<int> prices = new Queue<int>();
            int maxValueFromRandom = 9;
            int minValueFromRandom = 1;
            int maxPriceFromRandom = 99;
            int moneyOfShop = 0;
            int maxClients = random.Next(minValueFromRandom, maxValueFromRandom);
            int numberOfClient = 0;

            for (int i = 0; i < maxClients; i++)
            {
                int price = random.Next(maxPriceFromRandom);
                prices.Enqueue(price);
            }

            Console.WriteLine($"В очереди: {maxClients} клиентов.");

            while (maxClients > numberOfClient)
            {
                Console.WriteLine($"Следующий клиент: Клиент {numberOfClient + 1}");
                moneyOfShop += prices.Dequeue();
                numberOfClient++;
                Console.WriteLine($"Счет магазина: {moneyOfShop}");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"Счет магазина: {moneyOfShop}");
        }
    }
}
