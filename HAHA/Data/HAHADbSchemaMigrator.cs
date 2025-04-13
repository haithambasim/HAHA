using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace HAHA.Data;

public class HAHADbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public HAHADbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        
        /* We intentionally resolving the HAHADbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HAHADbContext>()
            .Database
            .MigrateAsync();

    }
}
