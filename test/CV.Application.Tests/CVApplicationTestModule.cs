using Volo.Abp.Modularity;

namespace CV;

[DependsOn(
    typeof(CVApplicationModule),
    typeof(CVDomainTestModule)
    )]
public class CVApplicationTestModule : AbpModule
{

}
