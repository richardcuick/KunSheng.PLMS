using Kunsheng.PLMS.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Kunsheng.PLMS.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PLMSController : AbpControllerBase
{
    protected PLMSController()
    {
        LocalizationResource = typeof(PLMSResource);
    }
}
