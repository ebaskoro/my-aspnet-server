/*
 * LoginResponse.cs
 *
 */

namespace Web.Models
{

    /// <summary>
    /// Login response.
    /// </summary>
    public class LoginResponse
    {

        /// <summary>
        /// Creates a login response.
        /// </summary>
        /// <param name="token">Token.</param>
        public LoginResponse(string token)
        {
            Token = token;
        }


        /// <summary>
        /// Gets the login token.
        /// </summary>
        public string Token { get; private set; }

    }

}
