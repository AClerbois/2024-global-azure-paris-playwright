using Microsoft.Extensions.Options;
using Sot.PlaywrightDemo.Web.Options;

namespace Sot.PlaywrightDemo.Web.Services;

public class EnvironmentProviderService
{
    private ApplicationOption _applicationOptions;

    public EnvironmentProviderService(IOptions<ApplicationOption> applicationOptions)
    {
        _applicationOptions = applicationOptions.Value;
    }

    public string Environment => _applicationOptions.Environment;

    public string BackgroundByEnvironment => Environment.ToLower() switch
    {
        "local" => "bg-blue-900",
        "development" => "bg-green-900",
        "staging" => "bg-red-900",
        "production" => "bg-gray-900",
        _ => "bg-orange-900"
    };


}