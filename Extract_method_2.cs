using System;

namespace HelloWorld
{
  class Program
  {
 		public void ProcessOrder(string customerName, string productName, int quantity)
		{
   
    		double totalPrice = CalculatePrice(quantity);
    
    		UpdateInventory(productName, quantity);

    		PrintReceipt(customerName, productName, quantity, totalPrice);

		}

		public double CalculatePrice(int quantity)
		{
    		const double taxRate = 0.1;
    		const double shippingFee = 1.5;
    		return quantity * taxRate + shippingFee;
		}

		public void UpdateInventory(string productName, int quantity)
		{
    
		}

		public void PrintReceipt(string customerName, string productName, int quantity, double totalPrice)
		{
    		Console.WriteLine($"Customer name: {customerName}");
    		Console.WriteLine($"Product name: {productName}");
    		Console.WriteLine($"Quantity: {quantity}");
    		Console.WriteLine($"Total price: {totalPrice}");
  
	}
  }
}