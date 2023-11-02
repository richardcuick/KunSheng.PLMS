using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Kunsheng.PLMS.Data;

/* This is used if database provider does't define
 * IPLMSDbSchemaMigrator implementation.
 */
public class NullPLMSDbSchemaMigrator : IPLMSDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
