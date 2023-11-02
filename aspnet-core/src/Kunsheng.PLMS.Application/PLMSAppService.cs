using System;
using System.Collections.Generic;
using System.Text;
using Kunsheng.PLMS.Localization;
using Volo.Abp.Application.Services;

namespace Kunsheng.PLMS;

/* Inherit your application services from this class.
 */
public abstract class PLMSAppService : ApplicationService
{
    protected PLMSAppService()
    {
        LocalizationResource = typeof(PLMSResource);
    }
}
