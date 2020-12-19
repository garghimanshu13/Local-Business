using Local_Business.Common.Models;
using Local_Business.Models.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Local_Business.Repo.Customers
{
    public class CustomerService : ICustomerService
    {
        public ErrorInfo RegisterCustomer(Customer customer)
        {
            return new ErrorInfo();
        }
    }
}
