using System;
using System.Collections.Generic;

/// <summary>
/// Author: Anthony. Bauld
/// Date: November 4th, 2021
/// Statement of Authorship: I, Anthony. Bauld, certify that this material is my original work. No other person's work has been used without due acknowledgement.
/// </summary>

namespace MidtermQ2
{
    class Invoice
    {
        static void Main(string[] args)
        {
            var Product = new List<IBillable>()
            {
                new Product(108715, "30inch Monitor", 1, 445.99m),
                new Product(119912, "Speakers", 2, 135.35m),
                new Product(191162, "FireTV Stick", 1, 65.39m),
                new Service("Configure", "Operating System", 135.25m),
                new Service("Debug", "Firefox", 25.89m),
                new Service("Backup", "SSD Drive", 125.19m),
            };

            Console.WriteLine("Current Month's Account Payable");
            foreach (Product p in Product)
            {
                Console.WriteLine(p);
            }
        }
    }
}
