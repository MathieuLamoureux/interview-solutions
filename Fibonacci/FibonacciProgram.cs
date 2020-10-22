using System;
public class FibonacciProgram
{
    public static void Main()
    {
        int userNum;
        Console.WriteLine("Enter number: ");
        userNum = Convert.ToInt32(Console.ReadLine());
        //call function here
        //display sequence array here
    }
    public static int[] FibonacciSequence(int x)
    {
        int prev = -1;
        int next = 1;
        int sum;
        int[] fib = new int[x];
        for(int i = 0; i < x; i++)
        {
            sum = prev + next;
            prev = next;
            next = sum;
            fib[i] = sum;
        }
        return fib;
    }
}
