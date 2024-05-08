using System;
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

        private int name;
        private float allowance;
        private bool bonus;
        private DateTime date;


        //methods and functions

        //constructs an allowance holder object 
        public AllowanceHolder(int name, DateTime date = default(DateTime))
        {
            this.name = name;
            //sets date to current date
            this.date = date == default(DateTime) ? DateTime.Now : date;
            //Set the initial allowance to $300
            this.allowance = 300;
            //set bonus to true
            bonus = true;

        }

        //Gets the name of the child
        public int Getname()
        {
            return name;
        }

        //Method used to set the allowance
        public void SetAllowance(float amount)
        {
            allowance = amount;
        }
        public float GetAllowance()
        {
            return allowance;


        }

        //Determines if the user is still intitiled to an allowance 
        public string CheckBonus()
        {
            //if user is bellow $50
            string status = "Bonus: No";
            if (bonus == true)
            {
                status = "Bonus: Yes";
            }
            return status;
        }

        //Gets name of the child who has purchased clothes 
        public int GetName()
        {
            return name;
        }

        //calculates the total that the user has spent 
        public float CalculateCost()
        {
            return 1f;
        }

        public string AnimalSummary(List<string> nameList)
        {
            //returns a string containing all the infomation the user need to know 
            string summary = $"Name: {nameList[name]}\nDate: {date.ToString("d", (new CultureInfo("es-ES")))}";

            return summary;

        }


        public string ToString()
        {
            return "";
        }


    }
}