using System;
public class TriangleProgram
{
    public static void Main()
    {
        double triBase;
        double triHeight;
        double area;

        Console.WriteLine("Enter base: ");
        triBase = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        triHeight = Convert.ToDouble(Console.ReadLine());
        area = TriangleArea(triBase, triHeight);
        Console.WriteLine("Triangle area is: " + area);
    }
    public static double TriangleArea(double b, double h)
    {
        double a;
        a = (b * h) / 2;
        return a;
    }
}
