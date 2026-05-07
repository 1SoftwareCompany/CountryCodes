using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_AWG()
    {
        Add(Country.AW, "Aruban florin", "AWG", 533, 2);
        Debug.Assert(_currenciesPerCountry[Country.AW].Count >= 1, $"{Country.AW} Number of currencies is wrong.");
    }
}
