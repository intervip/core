using Intervip.Core.Models;
using Intervip.Core.Models.Clients;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Intervip.Core.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
	public DbSet<Accommodation> Accommodations => Set<Accommodation>();
	public DbSet<Address> Addresses => Set<Address>();
	public DbSet<Bandwidth> Bandwidths => Set<Bandwidth>();
	public DbSet<Building> Buildings => Set<Building>();
	public DbSet<Client> Clients => Set<Client>();
	public DbSet<Company> Companies => Set<Company>();
	public DbSet<Contract> Contracts => Set<Contract>();
	public DbSet<Employee> Employees => Set<Employee>();
	public DbSet<Equipment> Equipment => Set<Equipment>();
	public DbSet<Group> Groups => Set<Group>();
	public DbSet<Manufacturer> Manufacturers => Set<Manufacturer>();
	public DbSet<Person> People => Set<Person>();
	public DbSet<PostalCode> PostalCodes => Set<PostalCode>();
	public DbSet<Sale> Sales => Set<Sale>();
	public DbSet<Shaft> Shafts => Set<Shaft>();
	public DbSet<Storey> Storeys => Set<Storey>();

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.HasDefaultSchema("Intranet");

		// Rename default identity tables and set the schema
		modelBuilder.Entity<ApplicationUser>(entity =>
			entity.ToTable("Users", "Identity"));
		modelBuilder.Entity<IdentityRole>(entity =>
			entity.ToTable("Roles", "Identity"));
		modelBuilder.Entity<IdentityUserRole<string>>(entity =>
			entity.ToTable("UserRoles", "Identity"));
		modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
			entity.ToTable("UserClaims", "Identity"));
		modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
			entity.ToTable("UserLogins", "Identity"));
		modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
			entity.ToTable("RoleClaims", "Identity"));
		modelBuilder.Entity<IdentityUserToken<string>>(entity =>
			entity.ToTable("UserTokens", "Identity"));

		// Set contract cost precision and scale
		modelBuilder.Entity<Contract>(entity =>
			entity.Property(contract => contract.Cost)
			.HasPrecision(7, 2));

		// Set cascade delete relation with employee
		modelBuilder.Entity<Sale>().HasOne(sale => sale.Salesperson)
			.WithMany(employee => employee.Sales)
			.OnDelete(DeleteBehavior.NoAction);
		modelBuilder.Entity<Sale>().HasOne( sale => sale.Client)
			.WithMany(client => client.Deals)
			.OnDelete(DeleteBehavior.NoAction);
	}
}
