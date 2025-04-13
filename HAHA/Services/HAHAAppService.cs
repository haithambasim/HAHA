using Volo.Abp.Application.Services;
using HAHA.Localization;

namespace HAHA.Services;

/* Inherit your application services from this class. */
public abstract class HAHAAppService : ApplicationService
{
    protected HAHAAppService()
    {
        LocalizationResource = typeof(HAHAResource);
    }
}