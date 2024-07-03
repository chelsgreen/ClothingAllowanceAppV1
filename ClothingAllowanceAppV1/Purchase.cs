using System;
namespace ClothingAllowanceAppV1

{
	public class Purchase

	{

		private DateTime datePurchased;
		private string description;
		private float amount;



		public Purchase(DateTime date, string description, float amount)

		{
			datePurchased = date;
			this.description = description;
			this.amount = amount;
		}

		public string purchaseSummary()

		{
			return datePurchased.ToString("dd/MM/yyyy") + "\t" + description + "\t" + amount;
		}

	}

}