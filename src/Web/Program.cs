/*
 * Program.cs
 *
 */

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;


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
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();
            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }

    }

}
