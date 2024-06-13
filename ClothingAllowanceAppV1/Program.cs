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

            AllowanceHolder testAH = new AllowanceHolder("Hana");

            //Sets the allowance for the Child to $300 

            testAH.SetAllowance(300);

            Console.WriteLine(testAH.Summary());

            Console.WriteLine(testAH.CheckBonus());

            Console.WriteLine($"Allowance: ${testAH.GetAllowance()}");



            Console.WriteLine("--------------------------------");



            // Use a while loop to continue deducting money until the user decides to stop 

            bool continueDeducting = true;

            while (continueDeducting)

            {

                Console.Write("Please enter the amount of money spent: \n");



                // Read user input as string 

                string userInput = Console.ReadLine();



                // Parse user input to convert it into a numeric value 

                if (int.TryParse(userInput, out int moneySpent))

                {

                    // Deduct the money spent from the allowance of the child 

                    testAH.DeductFromAllowance(moneySpent);

                    Console.WriteLine($"Allowance after deduction: ${testAH.GetAllowance()}");



                    Console.Write("Do you want to deduct more money? (yes/no): ");

                    string continueInput = Console.ReadLine().ToLower();



                    // Check if the user wants to continue deducting money, if not close the program 

                    if (continueInput != "yes")

                    {

                        continueDeducting = false;

                    }

                }

                //if the user enters something that is not a numerical value 

                else

                {

                    Console.WriteLine("Invalid input. Please enter a valid numeric value.");

                }

            }



            Console.WriteLine("Thank's for using Clothing Allowance App!");

            Console.ReadLine();

        }

    }

}