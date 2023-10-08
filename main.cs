using System;

public class Program
{
    private static double SaleD = 0;
    private static double SaleE = 0;
    private static double SaleF = 0;

    public static void Main(string[] args)
    {
        char salesperson;
        double saleAmount;

        Console.WriteLine("Enter salesperson initial (D, E, F) or Z to quit:");
        salesperson = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();  // For new line

        while (salesperson != 'Z')
        {
            if (salesperson == 'D' || salesperson == 'E' || salesperson == 'F')
            {
                Console.WriteLine("Enter sale amount:");
                saleAmount = double.Parse(Console.ReadLine());

                switch (salesperson)
                {
                    case 'D':
                        SaleD += saleAmount;
                        break;
                    case 'E':
                        SaleE += saleAmount;
                        break;
                    case 'F':
                        SaleF += saleAmount;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again.");
            }

            Console.WriteLine("\nEnter salesperson initial (D, E, F) or Z to quit:");
            salesperson = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();  // For new line
        }

        DisplayResults();
    }

    public static void DisplayResults()
    {
        double grandTotal = SaleD + SaleE + SaleF;
        Console.WriteLine($"\nD Sales: ${SaleD}");
        Console.WriteLine($"E Sales: ${SaleE}");
        Console.WriteLine($"F Sales: ${SaleF}");
        Console.WriteLine($"\nGrand Total: ${grandTotal}");

        if (SaleD > SaleE && SaleD > SaleF)
            Console.WriteLine("Highest Sale: D");
        else if (SaleE > SaleD && SaleE > SaleF)
            Console.WriteLine("Highest Sale: E");
        else
            Console.WriteLine("Highest Sale: F");
    }
}
