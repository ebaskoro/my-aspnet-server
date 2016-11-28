/*
 * LoginControllerTest.cs
 *
 */

using Microsoft.AspNetCore.Mvc;
using Web.Controllers;
using Web.Models;
using Xunit;


namespace Web.Controllers.Tests
{
    
    /// <summary>
    /// Unit tests for Login controller.
    /// </summary>
    public class LoginControllerTest
    {

        [Fact]
        public void Post_Returns_NotNull()
        {
            var target = new LoginController();

            var actual = target.Post(null);

            Assert.True(actual != null);
        }


        [Fact]
        public void Post_With_NullRequest_Returns_BadRequest()
        {
            var target = new LoginController();
            
            var actual = target.Post(null);

            Assert.IsType<BadRequestResult>(actual);
        }


        [Fact]
        public void Post_With_ValidRequest_Returns_Ok()
        {
            var request = new LoginRequest();
            var target = new LoginController();
            
            var actual = target.Post(request);

            Assert.IsType<OkObjectResult>(actual);
        }


        [Fact]
        public void Post_With_InvalidRequest_Returns_NotFound()
        {
            var request = new LoginRequest();
            var target = new LoginController();
            target.ModelState.AddModelError("email", "email");

            var actual = target.Post(request);

            Assert.IsType<NotFoundResult>(actual);
        }

    }

}
