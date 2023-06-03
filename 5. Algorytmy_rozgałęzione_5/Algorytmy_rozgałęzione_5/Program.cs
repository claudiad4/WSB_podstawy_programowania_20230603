using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Podaj dowolną liczbę:");
        a = inputValue();
        Console.WriteLine("Podaj liczbę, z którą chcesz porównać poprzednią liczbę:");
        b = inputValue();
        if (a == b)
        {
            Console.WriteLine("Te liczby są sobie równe!");
        }
        else
        if (a > b)
        {
            Console.WriteLine("Z dwóch podanych liczb, większa jest liczba:" + a);
        }
        else
        {
            Console.WriteLine("Z dwóch podanych liczb, większa jest liczba:" + b);
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


