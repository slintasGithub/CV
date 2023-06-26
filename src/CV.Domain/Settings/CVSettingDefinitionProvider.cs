using Volo.Abp.Settings;

namespace CV.Settings;

public class CVSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CVSettings.MySetting1));
    }
}
