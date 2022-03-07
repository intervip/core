using System.ComponentModel.DataAnnotations;

namespace Intervip.Core.Models.Clients;

public class Person : Client
{
	[MaxLength(11)]
	public string CPF { get; set; }
	public Company? Company { get; set; }

	public Person()
	{
		CPF = string.Empty;
	}
}
