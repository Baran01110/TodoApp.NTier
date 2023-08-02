using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.NTier.DataAccess.Contexts;

namespace TodoApp.NTier.Business.DependencyResolvers.Microsoft
{
   public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddDbContext<TodoContexts>(opt =>
            {
                opt.UseSqlServer("server= DESKTOP-12BR9N2; database=TodoDb; integrated security=true");
            });
        }
    }
}
