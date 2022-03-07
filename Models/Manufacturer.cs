using Intervip.Core.Models.Clients;

namespace Intervip.Core.Models;

public class Manufacturer : Company
{
	public string Name { get; set; }
	public IList<Equipment>? Equipment { get; set; }

	public Manufacturer()
	{
		Name = string.Empty;
	}
}
