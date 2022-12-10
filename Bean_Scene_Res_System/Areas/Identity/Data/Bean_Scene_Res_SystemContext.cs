using Bean_Scene_Res_System.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bean_Scene_Res_System.Data;

public class Bean_Scene_Res_SystemContext : IdentityDbContext<Bean_Scene_Res_SystemUser>
{
    public Bean_Scene_Res_SystemContext(DbContextOptions<Bean_Scene_Res_SystemContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
