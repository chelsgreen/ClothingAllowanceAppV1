using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingAllowanceAppV1

{

    class AllowanceManager

    {

        private List<AllowanceHolder> allowanceHolders = new List<AllowanceHolder>();

        readonly private List<string> NAMES = new List<string> { "Nikau", "Hana", "Tia" };



        public AllowanceManager()

        {

            //foreach loop through names list 

            foreach (var name in NAMES)

            {



            }



            //add new allowance holder to allowance holders list 



        }

        public int CalculateAvailableAllowance(string searchName)

        {

            //for each loop allowance holder in alowance holders 

            foreach (AllowanceHolder alowanceHolder in allowanceHolders)

            {



            }



            // if allowance holder name is = searchName 



            // get allowance by calling GetAllowance method 

            return 2;

        }

        public bool CheckAvailableAllowance(string searchName)

        {

            // foreach loop allowance holder in alowance holders 



            //if alowance holder name is =searchName 



            // check if they are able to make the purchase 





            return true;

        }



        //method that will check if selected allowance holder is on track for bonus 



        public int BonusTracker()

        {

            return 1;

        }



        //method that will return selected allowances holders summary 



        public string HoldersSummary()

        {

            //provide a string with infomation like name, allowance deducted, what they have purchased ith the price attached to it 

            return "";

        }



        //method that will deduct allowance that user wants to spend 



        public int deductAllowance()

        {

            //only deduct allowance if the user has enough otherwise promit a message 

            //saying that they are unable to make a purchase  

            return 1;

        }



        //method that will set bonus activity for a chosen allowance holder 



        public string SetBonus()

        {



            return "";

        }



    }

}



