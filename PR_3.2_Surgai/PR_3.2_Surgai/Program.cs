using System;

namespace PR_3._2_Surgai
{
    class Program
    {
        static void Main(string[] args)
        {
            var retailProperty = new RetailProperty(24.2M, "Пушкінська, 41", State.Rented, new Owner(), 124, DateTime.Now, "Роздрібна торгівля");

            Console.WriteLine(retailProperty.getCostPerSquareMeter());

        }
    }
}
