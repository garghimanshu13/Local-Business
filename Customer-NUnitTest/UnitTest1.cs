using Local_Business.Common.Models;
using Local_Business.Controllers;
using Local_Business.Models.Customers;
using Local_Business.Repo.Customers;
using NUnit.Framework;

namespace Customer_NUnitTest
{
    public class Tests
    {
        private ErrorInfo err = new ErrorInfo() { Status = false, Description = "" };
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RegisterCustomer()
        {
            Customer customer = new Customer();
            ICustomerService service = new CustomerService();
            var error = service.RegisterCustomer(customer);
            Assert.AreEqual(error.Status, err.Status);
           // Assert.Pass();
        }
    }
}