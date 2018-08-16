using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Data.Identity;
using StoreOfBuild.Domain.Products;
using StoreOfBuild.Domain.Sales;

namespace StoreOfBuild.Data.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
}

//
//Gerar o migrations
//dotnet ef --startup-project ..\StoreOfBuild.Web\StoreOfBuild.Web.csproj --project .\StoreOfBuild.Data.csproj migrations add AddCategory
//dotnet ef --startup-project ..\StoreOfBuild.Web\StoreOfBuild.Web.csproj --project .\StoreOfBuild.Data.csproj database update

// Gerar o Build
//dotnet run --project ..\StoreOfBuild.Web\StoreOfBuild.Web.csproj
// Usar F5 para realizar DEBUG
