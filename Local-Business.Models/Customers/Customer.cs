using Local_Business.Common.Models.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Local_Business.Models.Customers
{
    public class Customer : BaseCustomer
    {
        public string AlternatePhoneNumber { get; set; }
    }
}
