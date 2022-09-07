using Intervip.Core.Enums;

namespace Intervip.Core.Models;

public partial class PostalCode
{
	public Guid Id { get; init; }
	public required string Code { get; init; }
	public required string Street { get; init; }
	public required string Neighbourhood { get; init; }
	public required string City { get; init; }
	public required States State { get; init; }
	public DateTime AddedAt { get; init; }
	public IList<Address>? Addresses { get; set; }
}
