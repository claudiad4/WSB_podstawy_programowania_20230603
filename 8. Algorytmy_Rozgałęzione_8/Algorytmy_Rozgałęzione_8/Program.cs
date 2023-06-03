using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, działanie, wynikDodawania, wynikOdejmowania, wynikMnożenia, wynikDzielenia;

        Console.WriteLine("Wprowadź numer działania, które chcesz wykonać: Dodawanie (1), Odejmowanie (2), Mnożenie (3), Dzielenie (4)");
        działanie = (int)inputValue();
        if (działanie == 1)
        {
            Console.WriteLine("Wprowadź liczbę a:");
            a = (int)inputValue();
            Console.WriteLine("Wprowadź liczbę b:");
            b = (int)inputValue();
            wynikDodawania = a + b;
            Console.WriteLine("Wynik=" + wynikDodawania);
        }
        if (działanie == 2)
        {
            Console.WriteLine("Wprowadź liczbę a:");
            a = (int)inputValue();
            Console.WriteLine("Wprowadź liczbę b:");
            b = (int)inputValue();
            wynikOdejmowania = a - b;
            Console.WriteLine("Wynik=" + wynikOdejmowania);
        }
        if (działanie == 3)
        {
            Console.WriteLine("Wprowadź liczbę a:");
            a = (int)inputValue();
            Console.WriteLine("Wprowadź liczbę b:");
            b = (int)inputValue();
            wynikMnożenia = a * b;
            Console.WriteLine("Wynik=" + wynikMnożenia);
        }
        if (działanie == 4)
        {
            Console.WriteLine("Wprowadź liczbę a:");
            a = (int)inputValue();
            Console.WriteLine("Wprowadź liczbę b:");
            b = (int)inputValue();
            wynikDzielenia = (int)((double)a / b);
            if (b == 0)
            {
                Console.WriteLine($"Wynik= {a} /0");
            }
            else
            {
                Console.WriteLine("Wynik=" + wynikDzielenia);
            }
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
