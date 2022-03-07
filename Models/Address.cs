using System.ComponentModel.DataAnnotations;

namespace Intervip.Core.Models;

public class Address
{
	public int Id { get; set; }
	public int? Number { get; set; }
	public string Complement { get; set; }

	[Required]
	public PostalCode PostalCode { get; set; }

	public Address()
	{
		Complement = string.Empty;
		PostalCode = new PostalCode();
	}
}
