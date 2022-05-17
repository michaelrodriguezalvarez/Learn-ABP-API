using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ISUCore.Learn;

[Dependency(ReplaceServices = true)]
public class LearnBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Learn";
}
