/*
 * LoginController.cs
 *
 */

using Microsoft.AspNetCore.Mvc;
using Web.Models;


namespace Web.Controllers
{
    
    /// <summary>
    /// Login controller.
    /// </summary>
    [Route("api/v1/[controller]")]
    public class LoginController : Controller
    {

        /// <summary>
        /// Creates a login request.
        /// </summary>
        /// <param name="request">Login request to create.</param>
        [HttpPost]
        public IActionResult Post([FromBody]LoginRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            else if (ModelState.IsValid)
            {
                return Ok(new LoginResponse("dummytoken"));
            }
            else
            {
                return NotFound();
            }
        }

    }

}
