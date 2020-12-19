using Local_Business.Models.Customers;
using Local_Business.Repo.Customers;
using Microsoft.AspNetCore.Mvc;

namespace Local_Business.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _ICustomerService;
        public CustomerController(ICustomerService ICustomerService)
        {
            this._ICustomerService = ICustomerService;
        }

        [HttpPost]
        [Route("registercustomer")]
        public IActionResult RegisterCustomer([FromBody]Customer customer)
        {
            var result = _ICustomerService.RegisterCustomer(customer);
            return this.Ok(result);
        }
    }
}
