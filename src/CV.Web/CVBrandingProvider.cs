using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace CV.Web;

[Dependency(ReplaceServices = true)]
public class CVBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "CV";
}
