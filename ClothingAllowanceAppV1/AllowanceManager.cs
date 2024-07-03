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
                allowanceHolders.Add(new AllowanceHolder(name));
            }
            //add new allowance holder to allowance holders list 
        }



        public int CalculateAvailableAllowance(string searchName)
        {
            // for each loop allowance holder in allowance holders 
            foreach (AllowanceHolder allowanceHolder in allowanceHolders)

            {
                // if allowance holder name is = searchName 
                if (allowanceHolder.GetName().Equals(searchName, StringComparison.OrdinalIgnoreCase))

                {
                    // get allowance by calling GetAllowance method 
                    return (int)allowanceHolder.GetAllowance();
                }
            }

            return 0; // or some other value indicating the user was not found 

        }


        //method that will check if selected allowance holder is on track for bonus 
        public int BonusTracker(string searchName)

        {
            foreach (AllowanceHolder allowanceHolder in allowanceHolders)
            {
                if (allowanceHolder.GetName().Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    return allowanceHolder.GetBonus() ? 1 : 0; // 1 if on track for bonus, 0 if not 
                }

            }
            return -1; // user not found          
        }


        //method that will deduct allowance that user wants to spend 
        public string DeductAllowance(string searchName, int amount, DateTime date, string description)

        {
            foreach (AllowanceHolder allowanceHolder in allowanceHolders)
            {
                //only deduct allowance if the user has enough otherwise promit a message 
                if (allowanceHolder.GetName().Equals(searchName))
                {
                    if (allowanceHolder.AvailableAllowance(amount))
                    {
                        allowanceHolder.DeductFromAllowance(amount, date, description);
                        return $"Deducted {amount} from {searchName}'s allowance. Remaining allowance: {allowanceHolder.GetAllowance()}";
                    }

                    else
                    {
                        // only deduct allowance if the user has enough otherwise prompt a message saying that they are unable to make a purchase 
                        return $"Unable to deduct {amount}. Insufficient allowance.";
                    }
                }

            }

            return "Allowance holder not found.";

        }
        //method that will set bonus activity for a chosen allowance holder 

        public string SetBonus(string searchName, string activity)

        {

            foreach (AllowanceHolder allowanceHolder in allowanceHolders)

            {

                if (allowanceHolder.GetName().Equals(searchName))

                {

                    // Assuming the SetBonus method is intended to set a bonus activity. 

                    allowanceHolder.SetBonusActivity(activity);

                    return $"Set bonus activity for {searchName} to '{activity}'.";

                }

            }

            return "Allowance holder not found.";

        }

        public string AllowanceHolderSummary()

        {

            //provide a string with infomation like name, allowance deducted, what they have purchased ith the price attached to it 

            string allowanceHolderSummary = "";

            foreach (var allowanceHolder in allowanceHolders)

            {

                allowanceHolderSummary += allowanceHolder.AllowanceHolderSummary();

            }

            return allowanceHolderSummary;

        }

    }

}