using System;

namespace L150___Access_Modifiers
{
    internal class Company
    {
        public int numberOfEmployees;
        private string name;
        private double profitSoFar;

        public Company(string companyName)
        {
            name = companyName;
        }

        public Company()
        {
            name = "Untitled_Company";
        }

        public Company(int employees, string name)
        {
            this.name = name;
            numberOfEmployees = employees;
        }

        public string GetName()
        {
            return name;
        }

        public double GetProfitSoFar()
        {
            return profitSoFar;
        }

        public void EmploySomeone()
        {
            numberOfEmployees += 1;
        }

        public void YoureFired()
        {
            numberOfEmployees -= 1;
        }

        public double SellProducts(int numberOfProducts)
        {
            double profit = numberOfProducts * (3.0 - 0.01);

            profitSoFar += profit;

            return profit;
        }
    }
}
