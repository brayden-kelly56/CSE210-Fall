using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new();
        bool cont = true;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.WriteLine("Enter Number: ");
            string numInput = Console.ReadLine();
            int num = int.Parse(numInput);
            if (num == 0)
            {
                cont = false;
            }
            else
            {
                numbers.Add(num);
            }
        } while (cont == true);

        int sum = 0;
        int largest = 0;
        int tally = 0;
        foreach (int value in numbers)
        {
            sum += value;
            tally++;
            if (value >= largest)
            {
                largest = value;
            }
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(double)sum / tally}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}