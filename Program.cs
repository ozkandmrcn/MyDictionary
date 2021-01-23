using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customers = new MyDictionary<int, string>();

            customers.Add(1, "Ali");
            customers.Add(2, "Veli");
            customers.Add(3, "Ayşe");
            customers.Add(4, "Meltem");

            for (int i = 0; i < customers.keys.Length; i++)
            {
                Console.WriteLine("Müşteri Numarası: " + customers.keys[i] + "\n" + "Müşteri Adı: " + customers.values[i] + "\n" + "**************");
            }
        }
    }
}
