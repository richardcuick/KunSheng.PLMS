using Kunsheng.PLMS.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Kunsheng.PLMS;

[DependsOn(
    typeof(PLMSEntityFrameworkCoreTestModule)
    )]
public class PLMSDomainTestModule : AbpModule
{

}
