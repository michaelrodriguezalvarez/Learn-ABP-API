using System.Threading.Tasks;

namespace ISUCore.Learn.Data;

public interface ILearnDbSchemaMigrator
{
    Task MigrateAsync();
}
