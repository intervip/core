namespace Intervip.Core.Models;

public class Storey
{
	public int Id { get; set; }
	public int Number { get; set; }
	public Building Building { get; set; }
	public IList<Shaft>? Shafts { get; set; }
	public IList<Accommodation>? Accommodations { get; set; }

	public Storey()
	{
		Building = new Building();
	}
}
