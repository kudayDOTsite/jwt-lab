using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace JWT_LAB.Controllers
{
    [Authorize()]
    [Route("promotion")]
    public class PromotionController : Controller
    {
        [HttpGet("new")]
        public IActionResult Get()
        {
            foreach (var claim in HttpContext.User.Claims)
            {
                Console.WriteLine("Claim Type: {0}:\nClaim Value:{1}\n", claim.Type, claim.Value);
            }
            var promotionCode = Guid.NewGuid();
            return new ObjectResult($"JWT Doğrulandı!");
        }
    }
}
