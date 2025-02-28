//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Aspire.Hosting
{
    public static partial class JavaAppHostingExtension
    {
        public static ApplicationModel.IResourceBuilder<ApplicationModel.JavaAppContainerResource> AddJavaApp(this IDistributedApplicationBuilder builder, string name, ApplicationModel.JavaAppContainerResourceOptions options) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.JavaAppExecutableResource> AddJavaApp(this IDistributedApplicationBuilder builder, string name, string workingDirectory, ApplicationModel.JavaAppExecutableResourceOptions options) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.JavaAppContainerResource> AddSpringApp(this IDistributedApplicationBuilder builder, string name, ApplicationModel.JavaAppContainerResourceOptions options) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.JavaAppExecutableResource> AddSpringApp(this IDistributedApplicationBuilder builder, string name, string workingDirectory, ApplicationModel.JavaAppExecutableResourceOptions options) { throw null; }

        public static ApplicationModel.IResourceBuilder<ApplicationModel.JavaAppExecutableResource> WithMavenBuild(this ApplicationModel.IResourceBuilder<ApplicationModel.JavaAppExecutableResource> builder, MavenOptions? mavenOptions = null) { throw null; }
    }

    public sealed partial class MavenOptions
    {
        public string[] Args { get { throw null; } set { } }

        public string Command { get { throw null; } set { } }

        public string? WorkingDirectory { get { throw null; } set { } }
    }
}

namespace Aspire.Hosting.ApplicationModel
{
    public partial class JavaAppContainerResource : ContainerResource, IResourceWithServiceDiscovery, IResourceWithEndpoints, IResource
    {
        public JavaAppContainerResource(string name, string? entrypoint = null) : base(default!, default) { }
    }

    public partial class JavaAppContainerResourceOptions
    {
        public string[]? Args { get { throw null; } set { } }

        public string? ContainerImageName { get { throw null; } set { } }

        public string ContainerImageTag { get { throw null; } set { } }

        public string? ContainerRegistry { get { throw null; } set { } }

        public string? OtelAgentPath { get { throw null; } set { } }

        public int Port { get { throw null; } set { } }

        public int TargetPort { get { throw null; } set { } }
    }

    public partial class JavaAppExecutableResource : ExecutableResource, IResourceWithServiceDiscovery, IResourceWithEndpoints, IResource
    {
        public JavaAppExecutableResource(string name, string command, string workingDirectory) : base(default!, default!, default!) { }
    }

    public partial class JavaAppExecutableResourceOptions
    {
        public string? ApplicationName { get { throw null; } set { } }

        public string[]? Args { get { throw null; } set { } }

        public string? OtelAgentPath { get { throw null; } set { } }

        public int Port { get { throw null; } set { } }
    }
}