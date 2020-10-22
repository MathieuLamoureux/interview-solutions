using System;
public class RetailProgram
{
    public static void Main()
    {
        decimal change;
        Console.WriteLine("Enter change: ");
        change = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine(CalculateChangeDue(change));
    }
    public static string CalculateChangeDue(decimal x)
    {
        int toonie = 0;
        int loonie = 0;
        int quarter = 0;
        int dime = 0;
        int nickel = 0;
        while(x > 1.99m)
        {
            x -= 2m;
            toonie++;
        }
        while(x > 0.99m)
        {
            x -= 1m;
            loonie++;
        }
        while( x > 0.24m)
        {
            x -= 0.25m;
            quarter++;
        }
        while(x > 0.09m)
        {
            x -= 0.10m;
            dime++;
        }
        while(x > 0.04m)
        {
            x -= 0.05m;
            nickel++;
        }
        return "Toonies: " + toonie + " Loonies: " + loonie + " Quarters: " + quarter + " Dimes: " + dime + " Nickels: " + nickel + " and " + x + " goes to charity.";
    }
}
