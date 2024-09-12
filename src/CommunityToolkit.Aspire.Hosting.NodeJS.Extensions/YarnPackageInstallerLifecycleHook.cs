using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Lifecycle;

namespace CommunityToolkit.Aspire.Hosting.NodeJS.Extensions;

internal class YarnPackageInstallerLifecycleHook(
    ResourceLoggerService loggerService,
    ResourceNotificationService notificationService,
    DistributedApplicationExecutionContext context) : IDistributedApplicationLifecycleHook
{
    private readonly NodePackageInstaller _installer = new("yarn", loggerService, notificationService);

    public Task BeforeStartAsync(DistributedApplicationModel appModel, CancellationToken cancellationToken = default)
    {
        if (context.IsPublishMode)
        {
            return Task.CompletedTask;
        }

        return _installer.InstallPackages(appModel, cancellationToken);
    }
}
