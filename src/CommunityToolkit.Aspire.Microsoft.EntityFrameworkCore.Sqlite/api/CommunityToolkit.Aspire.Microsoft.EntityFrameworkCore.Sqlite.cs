//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Extensions.Hosting
{
    public static partial class AspireEFSqliteExtensions
    {
        public static void AddSqliteDbContext<TContext>(this IHostApplicationBuilder builder, string name, System.Action<SqliteEntityFrameworkCoreSettings>? configureSettings = null, System.Action<EntityFrameworkCore.DbContextOptionsBuilder>? configureDbContextOptions = null)
            where TContext : EntityFrameworkCore.DbContext { }
    }

    public sealed partial class SqliteEntityFrameworkCoreSettings
    {
        public string? ConnectionString { get { throw null; } set { } }

        public int DefaultTimeout { get { throw null; } set { } }

        public bool DisableHealthChecks { get { throw null; } set { } }
    }
}