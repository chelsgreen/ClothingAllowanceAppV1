using ClothingAllowanceAppV1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingAllowanceAppV1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>() { "Nikau", "Hana", "Tia" };

            Console.WriteLine("----Allowance Holder Testing----");



            AllowanceHolder testAH = new AllowanceHolder(0);
            testAH.SetAllowance(300);
            Console.WriteLine(testAH.AnimalSummary(name));
            Console.WriteLine(testAH.CheckBonus());
            Console.WriteLine($"Allowance: ${testAH.GetAllowance()}");

            Console.WriteLine("--------------------------------");
            Console.Write("Please Enter Money Spent");
            Console.ReadLine();
        }
    }
}