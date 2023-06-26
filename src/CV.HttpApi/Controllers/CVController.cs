using CV.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CV.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CVController : AbpControllerBase
{
    protected CVController()
    {
        LocalizationResource = typeof(CVResource);
    }
}
