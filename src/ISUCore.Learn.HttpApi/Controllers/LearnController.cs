using ISUCore.Learn.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ISUCore.Learn.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LearnController : AbpControllerBase
{
    protected LearnController()
    {
        LocalizationResource = typeof(LearnResource);
    }
}
