namespace Intervip.Core.Models;

public class Bandwidth
{
	public int Id { get; set; }
	public int Upload { get; set; }
	public int Download { get; set; }
	public IList<Contract>? Contracts { get; set; }
}
