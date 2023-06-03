using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, d, licznik, mianownik;

        Console.WriteLine("Podaj wartość liczby a:");
        a = inputValue();
        Console.WriteLine("Podaj wartość liczby b:");
        b = inputValue();
        Console.WriteLine("Podaj wartość liczby c:");
        c = inputValue();
        Console.WriteLine("Podaj wartość liczby d:");
        d = inputValue();
        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania.");
        }
        else
        {
            licznik = a * d + b * c;
            mianownik = b * d;
            Console.WriteLine("Licznik (x)=" + licznik);
            Console.WriteLine("Mianownik (y)=" + mianownik);
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
