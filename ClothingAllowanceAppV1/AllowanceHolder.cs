﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingAllowanceAppV1

{

    public class AllowanceHolder

    {

        //attributes or fields 

        private string name;

        private float allowance;

        private bool bonus;

        private DateTime date;

        private string bonusActivity;

        //methods and functions 



        //constructs an allowance holder object  

        public AllowanceHolder(string name, DateTime date = default(DateTime))

        {

            this.name = name;

            //sets date to current date 

            this.date = date == default(DateTime) ? DateTime.Now : date;

            //Set the initial allowance to $300 

            this.allowance = 300;

            //set bonus to true 

            bonus = true;



        }



        //method that will set bonus activity 

        public string SetBonus(string selectedActivity)

        {

            return "";

        }



        //Method used to set the allowance 

        public void SetAllowance(float amount)

        {

            allowance = amount;

        }



        //Gets the allowance the allowance holder want's to do 

        public float GetAllowance()

        {

            return allowance;

        }



        //Determines if the user is still intitiled to an allowance  

        public bool CheckBonus()

        {

            //if user is bellow $50 



            if (allowance <= 50)

            {

                bonus = false;

            }

            return bonus;

        }



        //Gets name of the child who has purchased clothes  

        public string GetName()

        {

            return name;

        }



        //calculates the total that the user has spent  

        public float CalculateCost()

        {



            return 300 - allowance;

        }



        public string Summary()

        {

            //returns a string containing all the infomation the user need to know  

            string summary = $"Name: {name}\nBonus: {bonus}";



            return summary;

        }





        //Deducts the allowance from the user that is selected 

        public void DeductFromAllowance(int amount)

        {

            if (amount <= allowance)

            {

                allowance -= amount;

            }

            else

            {

                //Message back to the user saying they can not deduct more than $300  

                Console.WriteLine("Cannot deduct more than the available allowance.");

            }

        }



        //create a method that checks if the user is able to make the purchase  

        public bool AvailableAllowance(float purchaseAmount)

        {

            // check if the remaining allowance is enough to make the purchase 

            return purchaseAmount <= allowance;

        }





        public string ToString()

        {

            return "";

        }



        public string BonusActivity { get; private set; }



        //sets the bonus activity for the user. 

        public void SetBonusActivity(string activity)

        {

            BonusActivity = activity;

        }


    }

}