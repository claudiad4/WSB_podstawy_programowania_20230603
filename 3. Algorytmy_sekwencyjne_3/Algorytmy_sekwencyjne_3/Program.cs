using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double waga, wzrost;

        Console.WriteLine("Proszę podać swoją wagę w kilogramach:");
        waga = inputValue();
        Console.WriteLine("Proszę podać swój wzrost w metrach:");
        wzrost = inputValue();
        double bMI;

        bMI = waga / (wzrost * wzrost);
        double roundedBMI = Math.Round(bMI, 2);
        Console.WriteLine("Twoje BMI wynosi:" + roundedBMI);
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
