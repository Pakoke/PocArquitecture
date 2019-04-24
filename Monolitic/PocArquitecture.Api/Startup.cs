using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PocArquitecture.Api.Diagnostic;
using PocArquitecture.Api.RequestExamples;
using PocArquitecture.BusinessLogic.Department;
using PocArquitecture.BusinessLogic.Hospital;
using PocArquitecture.BusinessLogic.Staff;
using PocArquitecture.BusinessLogic.Staff.Validations;
using PocArquitecture.Interfaces;
using PocArquitecture.Interfaces.BusinessLogic;
using PocArquitecture.Interfaces.BussinesLogic.Repositories;
using PocArquitecture.Interfaces.Persistance.Repositories;
using PocArquitecture.Persistance;
using PocArquitecture.Persistance.BusinessRepositories;
using PocArquitecture.Persistance.Context;
using PocArquitecture.Persistance.Repositories;
using Serilog;
using Swashbuckle.AspNetCore.Filters;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using System.Reflection;

namespace PocArquitecture.Api
{
    public class Startup
    {
        public IServiceProvider ServicesProvider { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Version = "v1",
                    Title = "Api PocArquitecture",
                    Description = "This is the AspNetCore provided by Dev of PocArquitecture",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Francisco Javier Ruiz de la Torre,Jose Angel",
                        Email = string.Empty,
                        Url = "https://github.com/Pakoke,https://github.com/ANG78"
                    },
                    License = new License
                    {
                        Name = "ToDo lincense",
                        Url = "https://example.com/license"
                    }
                });
                c.ExampleFilters();
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services.AddSwaggerExamplesFromAssemblyOf<CreateStaffModelExample>();
            services.AddSwaggerExamplesFromAssemblyOf<CreateHospitalModelExample>();
            services.AddSwaggerExamplesFromAssemblyOf<CreateDepartmentModelExample>();

            services.AddDbContext<PocArquitectureContext>(options =>
                //options.UseMySql(Configuration.GetConnectionString("DefaultConnection"))
                options.UseInMemoryDatabase(databaseName: "pocarquitecturedb")
                );

            ConfigureRepositoryServices(services);

        }


        private void ConfigureRepositoryServices(IServiceCollection services)
        {
            // Add Repositories.
            services.AddTransient<IAppConfigurationRepository, AppConfigurationRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IHospitalRepository, HospitalRepository>();
            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IStaffRepository, StaffRepository>();
            services.AddTransient<IStaffTypeRepository, StaffTypeRepository>();
            services.AddTransient<IPatientRepository, PatientRepository>();

            //GenericUoW
            services.AddTransient<IGenericUoW, GenericUoW>(sp => new GenericUoW(
                sp.GetRequiredService<PocArquitectureContext>(), false)
                );
            services.AddTransient<IStaffBusinessLogic, StaffBusinessLogic>();
            services.AddTransient<IHospitalBusinessLogic, HospitalBusinessLogic>();
            services.AddTransient<IDepartmentBusinessLogic, DepartmentBusinessLogic>();

            services.AddTransient<IStaffBusinessRepository, StaffBusinessRepository>();
            services.AddTransient<IHospitalBusinessRepository, HospitalBusinessRepository>();
            services.AddTransient<IDepartmentBusinessRepository, DepartmentBusinessRepository>();


            services.AddTransient<IStaffValidationAdd>(sp => new StaffValidationAdd(
                                                                 new StaffAsPersonValidate(
                                                                 new DoctorValidate(sp.GetService<IStaffBusinessRepository>(),
                                                                 new StaffValidate()
                                                       ))));

            services.AddTransient<IStaffValidationUpdate>(sp => new StaffValidationUpdate(
                                                                    new StaffAsPersonValidate(
                                                                    new DoctorValidate(sp.GetService<IStaffBusinessRepository>(),
                                                                    new StaffValidate()
                                                          ))));

            //services.AddTransient<IHospitalBusinessRepository, HospitalRepositoryHL>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            loggerFactory.AddSerilog();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .Enrich.FromLogContext()
                .CreateLogger();

            Log.Information("Starting up");

            app.UseMiddleware<SerilogMiddleware>();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PocArquitecture Api V1");
            });

            app.UseMvc();


        }
    }
}
