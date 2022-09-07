using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Intervip.Core.Models;

public class Address
{
	public Guid Id { get; init; }
	public required short? Number { get; init; }
	public required string? Square { get; set; }
	public required string? Lot { get; set; }
	public required string? Complement { get; init; }
	public DateTime AddedAt { get; init; }

	[Required]
	public required PostalCode PostalCode { get; set; }

	[JsonIgnore]
	public required Guid PostalCodeId { get; init; }
	public IList<Lead>? Leads { get; set; }
}
