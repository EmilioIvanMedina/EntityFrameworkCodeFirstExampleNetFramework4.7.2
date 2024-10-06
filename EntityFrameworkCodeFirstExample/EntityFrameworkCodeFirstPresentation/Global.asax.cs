using CustomerMessageApplication.Interfaces;
using CustomerMessageRepository.DatabaseModel;
using repo = CustomerMessageRepository.Repository;
using EntityFrameworkCodeFirstPresentation.App_Start;
using EntityFrameworkCodeFirstPresentation.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EntityFrameworkCodeFirstPresentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private IServiceProvider _serviceProvider;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var services = new ServiceCollection();

            ConfigurateServices(services);

            _serviceProvider = services.BuildServiceProvider();

            DependencyResolver.SetResolver(new MyDependencyResolver(_serviceProvider));
        }

        private void ConfigurateServices(ServiceCollection services)
        {
            services.AddTransient<ContactController>();

            services.AddScoped<CustomerMessageDbContext>();
            services.AddScoped<ICustomerMessageRepository, repo.CustomerMessageRepository>();
        }
    }
}
