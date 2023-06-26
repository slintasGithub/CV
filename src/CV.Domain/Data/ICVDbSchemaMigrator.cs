using System.Threading.Tasks;

namespace CV.Data;

public interface ICVDbSchemaMigrator
{
    Task MigrateAsync();
}
