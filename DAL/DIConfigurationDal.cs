using DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DIConfigurationDal
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            //DI need to know about AddTransient, AddSingleton, AddScoped
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
