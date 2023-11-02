using Kunsheng.PLMS.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Kunsheng.PLMS.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PLMSEntityFrameworkCoreModule),
    typeof(PLMSApplicationContractsModule)
    )]
public class PLMSDbMigratorModule : AbpModule
{
}
