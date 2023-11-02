using System.Threading.Tasks;

namespace Kunsheng.PLMS.Data;

public interface IPLMSDbSchemaMigrator
{
    Task MigrateAsync();
}
