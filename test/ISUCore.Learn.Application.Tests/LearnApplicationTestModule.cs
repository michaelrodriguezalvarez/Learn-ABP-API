using Volo.Abp.Modularity;

namespace ISUCore.Learn;

[DependsOn(
    typeof(LearnApplicationModule),
    typeof(LearnDomainTestModule)
    )]
public class LearnApplicationTestModule : AbpModule
{

}
