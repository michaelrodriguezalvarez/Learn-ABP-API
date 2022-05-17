using ISUCore.Learn.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ISUCore.Learn;

[DependsOn(
    typeof(LearnEntityFrameworkCoreTestModule)
    )]
public class LearnDomainTestModule : AbpModule
{

}
