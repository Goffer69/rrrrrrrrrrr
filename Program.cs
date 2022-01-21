using System;

namespace _2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Fordon bil1 = new Fordon();
            bil1.Märke = "BMW";
            Console.WriteLine(bil1.Märke);

            Fordon bil2 = new Fordon("Ford");
            Console.WriteLine(bil2.Märke);
        }

    }
}
