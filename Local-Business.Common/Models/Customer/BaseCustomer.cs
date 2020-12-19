using System;
using System.Collections.Generic;
using System.Text;

namespace Local_Business.Common.Models.Customer
{
    public abstract class BaseCustomer
    {
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
