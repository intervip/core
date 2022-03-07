using System.ComponentModel.DataAnnotations.Schema;

namespace Intervip.Core.Models;

public class Sale
{
	public int Id { get; set; }
	public DateTime When { get; set; }
	public IList<Contract>? Contracts { get; set; }
	public IList<Equipment>? Equipment { get; set; }
	
	//[ForeignKey("Client")]
	//public int ClientId { get; set; }
	public Client Client { get; set; }

	//[ForeignKey("Salesperson")]
	//public int SalespersonId { get; set; }
	public Employee Salesperson { get; set; }

	public Sale()
	{
		When = DateTime.Now;
		Client = new Client();
		Salesperson = new Employee();
	}
}
