/*
 * Startup.cs
 *
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace Web
{

    /// <summary>
    /// Application startup.
    /// </summary>
    public class Startup
    {

        /// <summary>
        /// Configures the services used by the application.
        /// </summary>
        /// <param name="services">Collection of services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        
        /// <summary>
        /// Configures the middleware used by the application.
        /// </summary>
        /// <param name="app">Application to configure.</param>
        /// <param name="env">Current environment the application is in.</param>
        /// <param name="loggerFactory">Factory for logger.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

    }

}
