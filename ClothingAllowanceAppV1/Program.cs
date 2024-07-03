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

            bool validBonusInput = false; // Initialize validBonusInput to false 

            while (!validBonusInput)

            {

                Console.WriteLine("Choose a bonus activity by entering the corresponding number:");

                for (int i = 0; i < bonusActivites.Count; i++)

                {

                    Console.WriteLine($"{i + 1}.{bonusActivites[i]}");

                }

                Console.Write("Enter the number corresponding to the bonus activity:");

                string activityNumberInput = Console.ReadLine();



                //return the selected activity back to the user 

                if (int.TryParse(activityNumberInput, out int activityNumber) && activityNumber >= 1

                    && activityNumber <= bonusActivites.Count)

                {

                    string selectedActivity = bonusActivites[activityNumber - 1];

                    testAH.SetBonus(selectedActivity);

                    Console.WriteLine($"Bonus activity selected is: {selectedActivity}");

                    validBonusInput = true; // Set validBonusInput to true to exit the loop 

                }

                else

                {

                    //if user selects something outside of the range or invalid like a letter 

                    Console.WriteLine("**Invalid input** Please enter a valid number" +

                        " corresponding to the bonus activity.");

                }

                Console.WriteLine("--------------------------------");

            }



            // Use a while loop to continue deducting money until the user decides to stop 

            bool continueDeducting = true;

            while (continueDeducting)

            {

                bool validMoneyInput = false; // Initialize validMoneyInput to false 

                while (!validMoneyInput)

                {

                    Console.Write("Please enter the amount of money spent: ");



                    string userInput = Console.ReadLine();



                    if (int.TryParse(userInput, out int moneySpent))

                    {

                        // Deduct the money spent from the allowance of the child 

                        testAH.DeductFromAllowance(moneySpent, new DateTime(2024, 06, 29), "hat");

                        Console.WriteLine($"Allowance after deduction: ${testAH.GetAllowance()}");

                        //Valid input recevied, exits the loop 

                        validMoneyInput = true;

                    }


                    else

                    {

                        //if the user enters something that is not vaild  

                        Console.WriteLine("**************************************************\n" +
                            "Invalid input. Please enter a valid numeric value.\n" +
                            "**************************************************");
                    }

                }



                bool validResponse = false;

                while (!validResponse)

                {

                    Console.Write("Do you want to deduct more money? (yes/no): ");

                    string continueInput = Console.ReadLine().ToLower();



                    if (continueInput == "yes")

                    {

                        validResponse = true; // Valid response, exit the loop and asks use to subtract more money 

                    }

                    else if (continueInput == "no")

                    {

                        continueDeducting = false; // User does not want to deduct more money, exit the outer loop 



                        validResponse = true; // Valid response, exit the loop 

                    }

                    else

                    {

                        // Stay in the loop to ask again for a valid response 

                        Console.WriteLine("**************************************************" +
                            "\nInvalid input. Please enter 'yes' or 'no'.\n" +
                            "**************************************************");

                    }

                }

            }


            // Closing message to user 

            Console.WriteLine("Thank's for using Clothing Allowance App!");

            Console.ReadLine();

        }



    }

}