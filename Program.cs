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
            decimal metros = Convert.ToDecimal(metro);
            string kms = "1000";
            int km = Convert.ToInt32(kms);
            decimal resultado = metros / km;
            string cms = "100";
            decimal cm = Convert.ToDecimal(cms);
            decimal resultado2 = metros * cm;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Seu resultado em quilômetros é: " + resultado + " km." + " E em centímetros é: " + resultado2 + " cm.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;




        }
    }
}
