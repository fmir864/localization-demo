using Microsoft.AspNetCore.Mvc.Localization;
using System.Reflection;
using WebRazor.Resources;

namespace WebRazor.Localizers;

public class SharedHtmlLocalizer
{
    private readonly IHtmlLocalizer _localizer;

    public SharedHtmlLocalizer(IHtmlLocalizerFactory factory)
    {
        var type = typeof(SharedResource);
        var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName ?? "");
        _localizer = factory.Create(nameof(SharedResource), assemblyName.Name ?? "");
    }

    public LocalizedHtmlString this[string key] => _localizer[key];

    public LocalizedHtmlString GetLocalizedString(string key)
    {
        return _localizer[key];
    }
}