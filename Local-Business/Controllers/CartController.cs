using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Local_Business.Controllers
{
    [Route("api/cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        public CartController()
        {
        }


        [HttpGet]
        [Route("/getusercart")]
        public IActionResult GetUserCart()
        {
            return this.Ok();
        }
    }
}
