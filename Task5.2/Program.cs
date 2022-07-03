using System;
using System.Collections.Generic;

namespace Task5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<int> clients = new Queue<int>();
            List<int> prices = new List<int>();
            int maxValueFromRandom = 9;
            int minValueFromRandom = 1;
            int maxPriceFromRandom = 99;
            int moneyOfShop = 0;
            int maxClients = random.Next(minValueFromRandom,maxValueFromRandom);
            int numberOfClient = 0;
            int numberOfPrice = 0;

            while (maxClients > numberOfClient)
            {
                clients.Enqueue(numberOfClient);
                numberOfClient++;
            }

            Console.WriteLine($"В очереди: {numberOfClient} клиентов.");

            for (int i = 0; i < clients.Count; i++)
            {
                int price = random.Next(maxPriceFromRandom);
                prices.Add(price);
            }

            numberOfClient = 0;

            while (maxClients > numberOfClient)
            {
                clients.Dequeue();
                Console.WriteLine($"Следующий клиент: Клиент {numberOfClient + 1} \nСтоймость продуктов: {prices[numberOfPrice]}");
                numberOfClient++;

                if (numberOfPrice <= prices.Count)
                    moneyOfShop += prices[numberOfPrice];

                numberOfPrice++;
                Console.WriteLine($"Счет магазина: {moneyOfShop}");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"Счет магазина: {moneyOfShop}");
        }
    }
}
