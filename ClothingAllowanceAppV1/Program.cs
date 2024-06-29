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

            List<string> bonusActivites = new List<string>() { "Movie Night", "Splash Planet", "Bowling" };



            Console.WriteLine("----Allowance Holder Testing----");



            AllowanceHolder testAH = new AllowanceHolder("Hana");

            //Sets the allowance for the Child to $300 

            testAH.SetAllowance(300);

            Console.WriteLine(testAH.Summary());

            Console.WriteLine($"Allowance: ${testAH.GetAllowance()}");



            Console.WriteLine("--------------------------------");



            //bonus activity selection 

            bool validInput = false; // Initialize validInput to false 

            while (!validInput)

            {

                Console.WriteLine("Choose a bonus activity by entering the corresponding number:");

                for (int i = 0; i < bonusActivites.Count; i++)

                { Console.WriteLine($"{i + 1}.{bonusActivites[i]}"); }

                Console.Write("Enter the number correponding to the bonus activity:");

                string activityNumberInput = Console.ReadLine();



                //return the selected activity back to the user 

                if (int.TryParse(activityNumberInput, out int activityNumber) && activityNumber >= 1

                    && activityNumber <= bonusActivites.Count)

                {

                    string selectedActivity = bonusActivites[activityNumber - 1];

                    testAH.SetBonus(selectedActivity);

                    Console.WriteLine($"Bonus activity selected is: {selectedActivity}");

                    validInput = true; // Set validInput to true to exit the loop 

                }

                else

                {

                    //if user selects something outside of the range or invalid like a letter 

                    Console.WriteLine("**Invalid input**Please enter a valid number corresponding to the bonus activity.");

                }



                Console.WriteLine("--------------------------------");

            }





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



                    Console.Write("Do you want to deduct more money? (yes/no):");

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

            //closing messgae 



            Console.WriteLine("Thank's for using Clothing Allowance App!");

            Console.ReadLine();

        }

    }

}