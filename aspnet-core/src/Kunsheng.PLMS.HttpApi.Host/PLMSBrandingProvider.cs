using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Kunsheng.PLMS;

[Dependency(ReplaceServices = true)]
public class PLMSBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PLMS";
}
