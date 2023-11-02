using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Kunsheng.PLMS.Data;
using Volo.Abp.DependencyInjection;

namespace Kunsheng.PLMS.EntityFrameworkCore;

public class EntityFrameworkCorePLMSDbSchemaMigrator
    : IPLMSDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePLMSDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the PLMSDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PLMSDbContext>()
            .Database
            .MigrateAsync();
    }
}
