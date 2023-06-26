using CV.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace CV;

[DependsOn(
    typeof(CVEntityFrameworkCoreTestModule)
    )]
public class CVDomainTestModule : AbpModule
{

}
