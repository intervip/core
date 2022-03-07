namespace Intervip.Core.Models;

public class Accommodation
{
	public int Id { get; set; }
	public int? Number { get; set; }
	public Storey Storey { get; set; }
	public Client? Client { get; set; }
	public IList<Contract>? Contracts { get; set; }

	public Accommodation()
	{
		Storey = new Storey();
	}
}
