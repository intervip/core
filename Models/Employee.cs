using Intervip.Core.Models.Clients;

namespace Intervip.Core.Models;

public class Employee : Person
{
	public IList<Sale>? Sales { get; set; }
}
