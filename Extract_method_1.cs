using System;

public class Program
{
    public static void Main(string[] args)
    {
        string customerName = "John";
        string productName = "Apple";
        int quantity = 2;

        double price = GetPrice(productName);
        double totalPrice = price * quantity;

        Console.WriteLine("Customer name: " + customerName);
        Console.WriteLine("Product name: " + productName);
        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Total price: " + totalPrice);
    }

    public static double GetPrice(string productName)
    {
        double price = 0;

        switch (productName)
        {
            case "Apple":
                price = 0.85;
                break;
            case "Orange":
                price = 1.1;
                break;
            default:
                price = 1.5;
                break;
        }

        return price;
    }
}
