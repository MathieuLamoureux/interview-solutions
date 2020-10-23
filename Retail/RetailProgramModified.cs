using System;
public class RetailProgramModified
{
    public static void Main()
    {
        Console.WriteLine("Enter pennies: ");
        int change = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CalculateChangeDue(change));
    }
    public static string CalculateChangeDue(int x)
    {
        int toonies = x / 200;
        x %= 200;
        int loonies = x / 100;
        x %= 100;
        int quarters = x / 25;
        x %= 25;
        int dimes = x / 10;
        x %= 10;
        int nickels = x / 5;
        int pennies = x % 5;

        return "Toonies: " + toonies + " Loonies: " + loonies + " Quarters: " + quarters + " Dimes: " + dimes + " Nickels: " + nickels + " Pennies: " + pennies;
    }
}
