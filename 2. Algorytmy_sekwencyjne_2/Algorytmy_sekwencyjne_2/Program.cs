using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Obliczanie obwodu koła");

        Console.Write("Podaj pole koła: ");
        double pole = double.Parse(Console.ReadLine());

        double promien = Math.Sqrt(pole / Math.PI);
        double obwod = 2 * Math.PI * promien;

        Console.WriteLine($"Obwód koła wynosi: {obwod}");
    }
}
