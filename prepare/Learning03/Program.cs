using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction F1 = new Fraction();
        Fraction F2 = new Fraction(5);
        Fraction F3 = new Fraction(3, 4);


        double decmial1 = F1.GetDecimalValue();
        string frac1 = F1.GetFractionString();

        double decmial2 = F2.GetDecimalValue();
        string frac2 = F2.GetFractionString();

        double decmial3 = F3.GetDecimalValue();
        string frac3 = F3.GetFractionString();

        Console.WriteLine($"{decmial1}");
        Console.WriteLine($"{frac1}");

        Console.WriteLine($"{decmial2}");
        Console.WriteLine($"{frac2}");

        Console.WriteLine($"{decmial3}");
        Console.WriteLine($"{frac3}");
    }
}