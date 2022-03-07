namespace Intervip.Core.Models;

public class Group
{
	public int Id { get; init; }
	public string Name { get; init; }
	public IList<Building>? Buildings { get; set; }

	public Group()
	{
		Name = string.Empty;
	}
}
