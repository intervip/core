using System.ComponentModel.DataAnnotations;

namespace Intervip.Core.Models.Clients;

public class Company : Client
{
	[MaxLength(14)]
	public string CNPJ { get; set; }
	public IList<Person>? People { get; set; }

	public Company()
	{
		CNPJ = string.Empty;
	}
}
