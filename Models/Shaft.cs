namespace Intervip.Core.Models;

public class Shaft
{
	public int Id { get; set; }
	public string Description { get; set; }
	public Storey Storey { get; set; }
	public IList<Equipment>? Equipment { get; set; }

	public Shaft()
	{
		Storey = new Storey();
		Description = string.Empty;
	}
}
