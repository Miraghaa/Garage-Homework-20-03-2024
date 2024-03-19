using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Homework_.Models;

public class CalcAve
{
    public int CalcAverage(params int[] arr)
    {
        int Average = 0;
        foreach (int i in arr)
        {
            Average += i;
        }
        return Average / arr.Length;
    }
    public int Result()
    {
        Console.WriteLine("Enter your results");
        Console.WriteLine("first exam");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("second exam");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("third exam");
        int third = int.Parse(Console.ReadLine());
        Console.WriteLine("four exam");
        int four = int.Parse(Console.ReadLine());
        Console.WriteLine("five exam");
        int five = int.Parse(Console.ReadLine());
        int TotalScore = CalcAverage(first, second, third, four, five);
        return TotalScore;
    }
}
