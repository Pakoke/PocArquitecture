﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NServiceBus;

namespace PocArquitecture.RequestHandler
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region NServiceBus

            #region EndpointConfiguration

            var endpointConfiguration = new EndpointConfiguration("PocArquitecture.RequestHandler");
            var transport = endpointConfiguration.UseTransport<LearningTransport>();
            endpointConfiguration.UsePersistence<LearningPersistence>();
            endpointConfiguration.EnableCallbacks(makesRequests: false);

            #endregion

            #region Routing

            //var routing = transport.Routing();
            //routing.RouteToEndpoint(
            //    assembly: typeof(ReplyApiMessage).Assembly,
            //    destination: "PocArquitecture.WriteApi");

            #endregion

            #region EndpointStart

            endpoint = Endpoint.Start(endpointConfiguration).GetAwaiter().GetResult();

            #endregion

            #region ServiceRegistration

            services.AddSingleton<IMessageSession>(endpoint);

            #endregion

            #endregion

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddLogging(loggingBuilder => loggingBuilder.AddDebug());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApplicationLifetime applicationLifetime)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            applicationLifetime.ApplicationStopping.Register(OnShutdown);

            app.UseMvc();
        }

        void OnShutdown()
        {
            endpoint?.Stop().GetAwaiter().GetResult();
        }

        IEndpointInstance endpoint;
    }
}