using Intervip.Core.Enums;

namespace Intervip.Core.Models;

public class Contract
{
	public int Id { get; set; }
	public Accommodation Accommodation { get; set; }
	public ContractStatus Status { get; set; }
	public decimal Cost { get; set; }
	public Bandwidth? Bandwidth { get; set; }
	public DateTime Start { get; set; }
	public DateTime? End { get; set; }
	public Contract? TransferedTo { get; set; }
	public Sale Sale { get; set; }
	public IList<Equipment>? Equipment { get; set; }

	public Contract()
	{
		Sale = new Sale();
		Accommodation = new Accommodation();
	}
}
