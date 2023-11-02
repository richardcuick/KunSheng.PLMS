using Volo.Abp.Modularity;

namespace Kunsheng.PLMS;

[DependsOn(
    typeof(PLMSApplicationModule),
    typeof(PLMSDomainTestModule)
    )]
public class PLMSApplicationTestModule : AbpModule
{

}
