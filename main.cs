using System;

class HomeSales
{
    static void Main(string[] args)
    {
        string[] salespeople = { "Danielle", "Edward", "Francis" };
        char[] initials = { 'D', 'E', 'F' };
        int[] totalSales = new int[3];

        Console.WriteLine("Enter salesperson initial (D, E, or F), or Z to exit:");
        char initial;
        do
        {
            Console.Write("Salesperson initial: ");
            initial = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (initial == 'Z')
                break;

            int index = Array.IndexOf(initials, initial);

            if (index == -1)
            {
                Console.WriteLine("Invalid initial. Please enter D, E, F, or Z.");
                continue;
            }

            Console.Write("Enter sale amount: ");
            int sale;
            if (!int.TryParse(Console.ReadLine(), out sale))
            {
                Console.WriteLine("Invalid sale amount. Please enter a valid integer.");
                continue;
            }

            totalSales[index] += sale;

        } while (initial != 'Z');

        int grandTotal = totalSales[0] + totalSales[1] + totalSales[2];
        string grandTotalFormatted = String.Format("{0:n0}", grandTotal);
        Console.WriteLine($"Grand Total: ${grandTotalFormatted}");

        int highestSalesIndex = totalSales[0] > totalSales[1] ? 
                                (totalSales[0] > totalSales[2] ? 0 : 2) : 
                                (totalSales[1] > totalSales[2] ? 1 : 2);
        Console.WriteLine($"Highest Sale: {initials[highestSalesIndex]} ({salespeople[highestSalesIndex]})");
    }
}
