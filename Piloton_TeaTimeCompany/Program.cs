using System;
public class Program
{
    public static void Main(string[] args)
    {
        const int shippingfee = 15;

        Console.WriteLine("Enter the no. of pound: ");
        int noOfPound = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the price per pound: ");
        double pricePerPoud = double.Parse(Console.ReadLine());

        Console.Write("Add shippping fee (Y/N): ");
        char shippinginformation = Console.ReadLine()[0];


        double totalamount = noOfPound * pricePerPoud;

        if (shippinginformation == 'Y')
        {
            totalamount = totalamount + shippingfee;
        }
        Console.WriteLine("Total Amount: {0:F2}", totalamount);

        Console.ReadKey();
    }
}