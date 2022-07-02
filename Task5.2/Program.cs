using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<string> clients = new Queue<string>();
            List<int> prices = new List<int>();
            int maxValueFromRandom = 9;
            int maxPriceFromRandom = 99;
            int moneyOfShop = 0;
            int maxClients = random.Next(maxValueFromRandom);
            int numberOfClient = 0;
            int numberOfPrice = 0;

            while (maxClients > numberOfClient)
            {
                clients.Enqueue("Клиент " + (numberOfClient + 1));
                numberOfClient++;
            }

            Console.WriteLine($"В очереди: {numberOfClient} клиентов.");

            for (int i = 0; i < clients.Count; i++)
            {
                int price = random.Next(maxPriceFromRandom);
                prices.Add(price);
            }

            while (clients.Count > 0)
            {
                Console.WriteLine($"Следующий клиент: {clients.Dequeue()}\nСтоймость продуктов: {prices[numberOfPrice]}");

                if (numberOfPrice <= prices.Count)
                    moneyOfShop += prices[numberOfPrice];

                numberOfPrice++;
                Console.WriteLine($"Счет магазина: {moneyOfShop}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
