using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Insira determinada medida em metros, e veja a medida em quilômetros e centímetros.");
            Console.ForegroundColor = ConsoleColor.Blue;
            string metro = Console.ReadLine();
            double metros = Convert.ToDouble(metro);
            string kms = "1000";
            int km = Convert.ToInt32(kms);
            double resultado = metros / km;
            string cms = "100";
            double cm = Convert.ToDouble(cms);
            double resultado2 = metros * cm;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{metros} m = {resultado} km");
            Console.WriteLine($"{metros} m = {resultado2} cm");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;




        }
    }
}
