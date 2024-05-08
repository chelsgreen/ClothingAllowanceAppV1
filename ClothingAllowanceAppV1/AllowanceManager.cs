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
		private List<string> names = new List<string> { "Nikau", "Hana", "Tia" };

		public AllowanceManager()
		{

		}
		public int CalculateAvailableAllowance()
		{
			return 2;
		}
		public bool CheckAvailableAllowance()
		{
			return true;
		}
		public void AddAnimalHolder(AllowanceHolder newAllowance)
		{
			allowanceHolders.Add(newAllowance);
		}

	}
}