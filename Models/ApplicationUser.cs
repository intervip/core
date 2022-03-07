using Microsoft.AspNetCore.Identity;

namespace Intervip.Core.Models;

public class ApplicationUser : IdentityUser
{
	public string DisplayName { get; set; }
	public int ClientId { get; set; }
	public Client Client { get; set; }

	public ApplicationUser() : base()
	{
		Client = new Client();
		DisplayName = string.Empty;
	}
}
