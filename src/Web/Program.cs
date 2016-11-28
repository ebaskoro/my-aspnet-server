/*
 * Program.cs
 *
 */

using Microsoft.AspNetCore.Hosting;


namespace Web
{

    /// <summary>
    /// Main entry point.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Executes the application.
        /// </summary>
        /// <param name="args">Collection of arguments.</param>
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }

    }

}
