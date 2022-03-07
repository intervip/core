namespace Intervip.Core.Models;

public class Client
{
	public int Id { get; set; }
	public ApplicationUser? User { get; set; }
	public IList<Accommodation>? Accommodations { get; set; }
	public IList<Sale>? Deals { get; set; }
}

public record OnlineClient(string Status, int Code, string Complement, string IPAddress, string LastLogin, string LastLogout);