using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CV.Data;

/* This is used if database provider does't define
 * ICVDbSchemaMigrator implementation.
 */
public class NullCVDbSchemaMigrator : ICVDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
