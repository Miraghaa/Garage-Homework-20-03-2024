using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Homework_.Models;

public class Product
{
    public string Name;
    public int Price;
    public int Count;
    public int TotalIncome;

    public void FullInfo()
    {
        Console.WriteLine($"Product Name: {Name}, Product price {Price}, Product count {Count}, Product totalincome {TotalIncome}.");
    }
    public void TotalInCome()
    {
        Console.WriteLine($"Product totalincome {TotalIncome}.");
    }
    public void AddProduct()
    {
        Console.WriteLine("Add the product Name");
        Name = Console.ReadLine();
        Console.WriteLine("Add the product price");
        Price = int.Parse( Console.ReadLine() );
        Console.WriteLine("Add the product count");
        Count = int.Parse(Console.ReadLine());
    }
    public void Sell()
    {
        Console.WriteLine("You want to buy a product");
        bool Sell = bool.Parse(Console.ReadLine());
        if (Sell)
        {
            Console.WriteLine("How much you want ?");
            int want = int.Parse( Console.ReadLine());
            if (want <= Count) 
            {
                Console.WriteLine($" Pay to {want * Price} manat");
                bool BuyOrNot = bool.Parse( Console.ReadLine());
                if (BuyOrNot)
                {
                    TotalIncome = want * Price;
                    Count -= want;
                    Console.WriteLine("Successfully");
                    TotalInCome();
                }
                else
                {
                    Console.WriteLine("GoodBye");
                }
            }
            else
            {
                Console.WriteLine("There is no product left");
            }
        }
        else
        {
            Console.WriteLine("Goodbye");
        }
    }
}
