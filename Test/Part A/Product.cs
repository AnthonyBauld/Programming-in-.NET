using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermQ2
{
    class Product : IBillable
    {
        public readonly int ProductID;
        public readonly string Description;
        public readonly int Quantity;
        public readonly decimal Cost;

        public Product(int productid, string desciption, int quantity, decimal cost)
        {
            this.ProductID = productid;
            this.Description = desciption;
            this.Quantity = quantity;
            this.Cost = cost;

            try
            {
                if (Quantity > 0)
                {
                    this.Quantity = quantity;
                }
            }
            catch (Exception)
            {
                throw new Exception("Quantity was not a postitve integer.");
            }
            try
            {
                if (Cost > 0)
                {
                    this.Cost = cost;
                }
            }
            catch (Exception)
            {
                throw new Exception("Cost was not a postitve integer.");
            }
        }

        public override string ToString()
        {
            return $"Product: {ProductID}, Description: {Description}, Quantity: ${Cost}";
        }

        public decimal Bill()
        {
            return Quantity * Cost;
        }

            public bool Validate()
        {
            if (ProductID == 10 || ProductID == 11 || ProductID == 12 || ProductID == 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
