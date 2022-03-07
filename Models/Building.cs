namespace Intervip.Core.Models;

public class Building
{
	public int Id { get; set; }
	public Group Group { get; set; }
	public string Name { get; set; }
	public Address Address { get; set; }
	public IList<Storey>? Storeys { get; set; }

	public Building()
	{
		Group = new Group();
		Address = new Address();
		Name = string.Empty;
	}
}