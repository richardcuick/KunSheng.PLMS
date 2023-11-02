using Volo.Abp.Settings;

namespace Kunsheng.PLMS.Settings;

public class PLMSSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PLMSSettings.MySetting1));
    }
}
