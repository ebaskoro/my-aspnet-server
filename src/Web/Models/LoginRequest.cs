/*
 * LoginRequest.cs
 *
 */

using System.ComponentModel.DataAnnotations;


namespace Web.Models
{
    
    /// <summary>
    /// Login request.
    /// </summary>
    public class LoginRequest
    {
        
        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [Required(
            ErrorMessage = "Email address is required",
            AllowEmptyStrings = false
        )]
        public string Email { get; set; }


        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [Required(
            ErrorMessage = "Password is required",
            AllowEmptyStrings = false
        )]
        public string Password { get; set; }

    }

}
