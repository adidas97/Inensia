using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // We read the given input of our gross salary amount. And then we say that our Imaginaria is equal to gross salary, after that
            // we will see if it stay with the same amount, or will be changed based on the rules.

            double grossSalary = double.Parse(Console.ReadLine());
            double imaginaria = grossSalary;

            // First we check the value of gross salary, if it's less than 1000 we make nothing.

            if (grossSalary <= 1000) { }

            // Here we check if the value is bigger than 1000, so to make the calculation

            else if (grossSalary > 1000)
            {
                // In case where we have more than 1000, we remove 1000, because of the following the logic of the given example.

                double incomeTax = grossSalary-1000;
                double socialContributions = 0;

                // If the amount of gross salary is bigger than 3000, we assign amount of 2000, because of the logic of the given example.
                if (grossSalary >= 3000)
                {
                    socialContributions = 2000;
                    
                } // Such as in incomeTax we need to remove 1000, because we accept that untill 1000 there is no taxes.
                else if (grossSalary > 1000)
                {
                    socialContributions = grossSalary - 1000;
                }

                // We create variables in which we assign the value which after we need to remove from gross salary to get the net salary
                double AddingPercentageToIncomeTax = incomeTax * 0.1;
                double AddingPercentageToSocialContributions = socialContributions * 0.15;

                imaginaria -= (AddingPercentageToIncomeTax + AddingPercentageToSocialContributions);
            } 

            Console.WriteLine($"{imaginaria} IDR");
        }
    }
}
