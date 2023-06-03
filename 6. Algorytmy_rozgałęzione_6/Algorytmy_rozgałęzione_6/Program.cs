using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj dłogość pierwszego boku trójkąta:");
        a = inputValue();
        Console.WriteLine("Podaj długość drugiego boku trójkąta:");
        b = inputValue();
        Console.WriteLine("Podaj długość drugiego boku trójkąta:");
        c = inputValue();
        double długośćBokówtrójkąta;

        if (a == b && a == c && b == c)
        {
            Console.WriteLine("Podane przez Ciebie długości boków wskazują, że trójkąt ten JEST trójkątem równobocznym.");
        }
        else
        {
            Console.WriteLine("Podane przez Ciebie długości boków wskazują, że trójkąt ten NIE JEST trójkątem równobocznym.");
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

