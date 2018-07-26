using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Data.Migration;

using OrchardCore.Modules;

namespace Alternating
{
    public class Startup:StartupBase
    {
 
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDataMigration, Migrations>();
        }
    }
}
