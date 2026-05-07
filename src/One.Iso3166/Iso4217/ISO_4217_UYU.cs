using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_UYU()
    {
        Add(Country.UY, "Uruguayan peso", "UYU", 858, 2);
        Debug.Assert(_currenciesPerCountry[Country.UY].Count >= 1, $"{Country.UY} Number of currencies is wrong.");
    }
}
