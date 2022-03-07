namespace Intervip.Core.Models.Equipments;

public class Switch : Equipment
{
	public IList<Port> Ports { get; set; }

	public Switch()
	{
		Ports = new List<Port>();
	}
}

public class Port
{
	public int Id { get; set; }
	public Equipment Equipment { get; set; }

	public Port()
	{
		Equipment = new Equipment();
	}
}
