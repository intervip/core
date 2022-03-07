using Intervip.Core.Enums;

using System.ComponentModel.DataAnnotations;

namespace Intervip.Core.Models;

public class PostalCode
{
	[MaxLength(7)]
	public string Id { get; set; }
	public string Street { get; set; }
	public string Neighbourhood { get; set; }
	public string City { get; set; }
	public States State { get; set; }
	public IList<Address>? Addresses { get; set; }

	public PostalCode()
	{
		Id = string.Empty;
		Street = string.Empty;
		Neighbourhood = string.Empty;
		City = string.Empty;
		State = States.EspíritoSanto;
	}
}
