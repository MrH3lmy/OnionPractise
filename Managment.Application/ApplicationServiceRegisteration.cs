using Managment.Application.Profiles;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application
{
    public static class ApplicationServiceRegisteration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection Services)
        {
            Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //  Services.AddAutoMapper(typeof(MappingProfile).Assembly);
            Services.AddMediatR(Assembly.GetExecutingAssembly());

            return Services;
        }
    }
}
