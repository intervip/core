using Intervip.Core.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Intervip.Core.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
	public DbSet<Lead> Leads => Set<Lead>();
	public DbSet<Address> Addresses => Set<Address>();
	public DbSet<PostalCode> PostalCodes => Set<PostalCode>();

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

		// Set CEP max length to 8 characteres
		modelBuilder.Entity<PostalCode>()
			.Property(postalCode => postalCode.Code)
			.HasMaxLength(8);
		modelBuilder.Entity<PostalCode>()
			.HasIndex(postalCode => postalCode.Code)
			.IsUnique();
		modelBuilder.Entity<PostalCode>()
			.Property(postalCode => postalCode.AddedAt)
			.HasDefaultValueSql("GETUTCDATE()");

		// Create unique index for addresses
		modelBuilder.Entity<Address>().HasIndex(address => new
		{
			address.Lot,
			address.Square,
			address.Number,
			address.PostalCodeId
		}).IsUnique();
		modelBuilder.Entity<Address>()
			.Property(address => address.PostalCodeId)
			.IsRequired();
		modelBuilder.Entity<Address>()
			.Property(address => address.Lot)
			.HasMaxLength(4);
		modelBuilder.Entity<Address>()
			.Property(address => address.Square)
			.HasMaxLength(4);
		modelBuilder.Entity<Address>()
			.HasCheckConstraint("CK_Address_Number_Complement", 
			 "[Number] IS NOT NULL OR ([Square] IS NOT NULL AND [Lot] IS NOT NULL)");
		modelBuilder.Entity<Address>()
			.Property(address => address.AddedAt)
			.HasDefaultValueSql("GETUTCDATE()");

		// Create unique index for leads
		modelBuilder.Entity<Lead>().HasIndex(lead => new
		{
			lead.Name,
			lead.Email,
			lead.PhoneNumber,
			lead.AddressId
		}).IsUnique();
		modelBuilder.Entity<Lead>()
			.Property(lead => lead.AddedAt)
			.HasDefaultValueSql("GETUTCDATE()");
	}
}
