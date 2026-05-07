using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MMK()
    {
        Add(Country.MM, "Myanmar kyat", "MMK", 104, 2);
        Debug.Assert(_currenciesPerCountry[Country.MM].Count >= 1, $"{Country.MM} Number of currencies is wrong.");
    }
}
