using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermQ2
{
    class Service : IBillable
    {
        public readonly string ServiceID;
        public readonly string Detail;
        public readonly decimal Price;

        public Service(string serviceid, string detail, decimal price)
        {
            this.ServiceID = serviceid;
            this.Detail = detail;
            this.Price = price;

            try
            {
                if (Price > 0)
                {
                    this.Price = price;
                }
            }
            catch (Exception)
            {
                throw new Exception("Price was not a postitve integer.");
            }
        }

        public override string ToString()
        {
            return $"Service: {ServiceID}, Description: {Detail}, Quantity: ${Price}";
        }

        public decimal Bill() => Price;

        public bool Validate()
        {
            if (ServiceID == "configure" ||  ServiceID == "debug" || ServiceID == "restore")
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
