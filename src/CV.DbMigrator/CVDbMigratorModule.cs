using CV.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace CV.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CVEntityFrameworkCoreModule),
    typeof(CVApplicationContractsModule)
    )]
public class CVDbMigratorModule : AbpModule
{

}
