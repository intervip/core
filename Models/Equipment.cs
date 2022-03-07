namespace Intervip.Core.Models;

public class Equipment
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Model { get; set; }
	public Manufacturer Manufacturer { get; set; }
	public IList<Sale>? Sales { get; set; }
	public IList<Contract>? Contracts { get; set; }
	public IList<Shaft>? Shafts { get; set; }

	public Equipment()
	{
		Name = string.Empty;
		Model = string.Empty;
		Manufacturer = new Manufacturer();
	}
}
