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
    public static partial class RustAppHostingExtension
    {
        public static ApplicationModel.IResourceBuilder<ApplicationModel.RustAppExecutableResource> AddRustApp(this IDistributedApplicationBuilder builder, string name, string workingDirectory, string[]? args = null) { throw null; }
    }
}

namespace Aspire.Hosting.ApplicationModel
{
    public partial class RustAppExecutableResource : ExecutableResource, IResourceWithServiceDiscovery, IResourceWithEndpoints, IResource
    {
        public RustAppExecutableResource(string name, string workingDirectory) : base(default!, default!, default!) { }
    }
}