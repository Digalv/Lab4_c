using Lab4_c;

internal class Program
{
    private static void Main(string[] args)
    {
        Drob d1 = new Drob(3, 7); Drob d2 = new Drob(2, 5);
        Drob d3 = new Drob(1, 2);
        Console.WriteLine((d3 - d1) * d3); 
        Console.WriteLine((d1 + d2) / d1.pow(3));
        Console.WriteLine(d1 < d2); 
        Console.WriteLine(d2 < d3);
        Console.WriteLine(d1 > d3);
    }
}