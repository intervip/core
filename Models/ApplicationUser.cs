using Microsoft.AspNetCore.Identity;

namespace Intervip.Core.Models;

public class ApplicationUser : IdentityUser
{
	public required string DisplayName { get; set; }
}