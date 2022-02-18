using Microsoft.Extensions.DependencyInjection;
using MyAutoFix.Repository;

namespace MyAutoFix.Extensions
{
    public static class AppRepositories
    {
        public static IServiceCollection AddAppRepositories(this IServiceCollection services)
        {
            services.AddScoped<FailureRepo>();
            services.AddScoped<ServiceProductRepo>();
            services.AddScoped<CartRepo>();


            return services;

        }
    }
}
