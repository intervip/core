using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Intervip.Core.Models;

public class Lead
{
	public Guid Id { get; init; }
	public required string Name { get; init; }
	public required string? Email { get; init; }
	public required string PhoneNumber { get; init; }
	public DateTime AddedAt { get; init; }

	[Required]
	public required Address Address { get; set; }

	[JsonIgnore]
	public required Guid AddressId { get; set; }
}
