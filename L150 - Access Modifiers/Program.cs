using System;

namespace L150___Access_Modifiers
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Company business = new Company("Henkel");

            business.numberOfEmployees = 47000;

            business.EmploySomeone();
            business.YoureFired();

            for (int i = 0; i < 67; i++)
            {
                Console.Write($"Day {i+1}: ");
                double profitToday = business.SellProducts(650000);
                Console.WriteLine($"£{profitToday} made selling Pritt sticks today");
            }

            Console.WriteLine($"Final profit for {business.GetName()}: £{business.GetProfitSoFar()}");
        }
    }
}
