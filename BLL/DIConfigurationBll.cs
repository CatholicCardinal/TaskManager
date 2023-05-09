using BLL.Interfaces;
using BLL.Services;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DIConfigurationBll
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAuthorizationService, AuthorizationService>();
			services.AddTransient<IWorkspaceService, WorkspaceService>();
			DIConfigurationDal.ConfigureServices(services);
        }
    }
}
