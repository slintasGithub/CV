using System;
using System.Collections.Generic;
using System.Text;
using CV.Localization;
using Volo.Abp.Application.Services;

namespace CV;

/* Inherit your application services from this class.
 */
public abstract class CVAppService : ApplicationService
{
    protected CVAppService()
    {
        LocalizationResource = typeof(CVResource);
    }
}
