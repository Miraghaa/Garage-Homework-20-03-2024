using System.Globalization;

namespace Garage_Homework_.Models;

public class SuperMarket
{
    public double Discount(double one, double two, double three)
    {
        if (one >= two && one >= three && two >= three) return one + two;
        else if (one >= two && one >= three && three >= two) return one + three;
        else if (two >= one && two >= three && one >= three) return two + one;
        else if (two >= one && two >= three && three >= one) return two + three;
        else if (three >= one && three >= two && two >= one) return two + three;
        else return three + one;

        //double[] doubles = {one,  two, three};
        //Array.Sort(doubles);
        //return doubles[2] + doubles[1];
    }

    public void Result()
    {
        Console.WriteLine("Add the products prices");
        Console.WriteLine("first price");
        double first = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("second price");
        double second = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("third price");
        double third = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine($"The amount you will pay {Discount(first, second, third)}");
    }
}
