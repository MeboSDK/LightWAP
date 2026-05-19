using LightWAP.Core.Infrastructure.DependencyManagment;
using LightWAP.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LightWAP.Data.Repository
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public void Register(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
        public int Order => 0;
    }
}
