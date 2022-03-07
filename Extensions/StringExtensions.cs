using System.Globalization;
using System.Text;

namespace Intervip.Core.Extensions;

public static class StringExtensions
{
	public static string? Normalize(this string? text, bool removeDiacritics = false)
	{
		if (string.IsNullOrWhiteSpace(text)) return text;
		text = text.Normalize(NormalizationForm.FormD);
		var chars = text.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
		return new string(chars).Normalize(NormalizationForm.FormC);
	}
}
