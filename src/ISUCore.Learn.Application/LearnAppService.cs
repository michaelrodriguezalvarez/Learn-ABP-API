using System;
using System.Collections.Generic;
using System.Text;
using ISUCore.Learn.Localization;
using Volo.Abp.Application.Services;

namespace ISUCore.Learn;

/* Inherit your application services from this class.
 */
public abstract class LearnAppService : ApplicationService
{
    protected LearnAppService()
    {
        LocalizationResource = typeof(LearnResource);
    }
}
