using CV.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CV.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CVPageModel : AbpPageModel
{
    protected CVPageModel()
    {
        LocalizationResourceType = typeof(CVResource);
    }
}
