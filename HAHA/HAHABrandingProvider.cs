using Microsoft.Extensions.Localization;
using HAHA.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace HAHA;

[Dependency(ReplaceServices = true)]
public class HAHABrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<HAHAResource> _localizer;

    public HAHABrandingProvider(IStringLocalizer<HAHAResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}