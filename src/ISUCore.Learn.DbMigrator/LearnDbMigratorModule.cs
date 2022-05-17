using ISUCore.Learn.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ISUCore.Learn.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LearnEntityFrameworkCoreModule),
    typeof(LearnApplicationContractsModule)
    )]
public class LearnDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
