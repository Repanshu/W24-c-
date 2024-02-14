using System;

class RoseBlanches
{
    static void Main()
    {
        // Asking the users how much money aunt gave
        Console.Write("How much did you receive money ($)? ");
        double totalMoney = double.Parse(Console.ReadLine());

        // Calculate 3/4 for books and supplies
        double booksAndSupplies = totalMoney * 0.75;

        // Calculate the remaining money for coffee, tickets etc
        double remainingMoney = totalMoney - booksAndSupplies;

        // Calculate the even split between coffees, Flash Computer journals and subway tickets

        double evenMoney = remainingMoney/3;

        // Calculate the amount of coffees, Flash Computer journals, and subway tickets that we can buy
        int coffees = (int)(evenMoney / 2);
        int flashComputers = (int)(evenMoney / 4);
        int subwayTickets = (int)(evenMoney / 3);

        // Output the result
        Console.WriteLine($"Book and Supplies: {booksAndSupplies} $");
        Console.WriteLine($"You can then buy:");
        Console.WriteLine($"{coffees} coffees");
        Console.WriteLine($"{flashComputers} Flash Computer Numbers");
        Console.WriteLine($"{subwayTickets} subway Tickets");

        // Calculate the remaining money for white roses
        double remainingForRoses = remainingMoney - (coffees * 2 + flashComputers * 4 + subwayTickets *3);

        // Output the remaining money for white roses
        Console.WriteLine($"and you will have {remainingForRoses} dollars for the white roses.");
    }
}
