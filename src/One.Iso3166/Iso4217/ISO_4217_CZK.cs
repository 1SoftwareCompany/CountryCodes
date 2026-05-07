using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CZK()
    {
        Add(Country.CZ, "Czech koruna", "CZK", 203, 2);
        Debug.Assert(_currenciesPerCountry[Country.CZ].Count >= 1, $"{Country.CZ} Number of currencies is wrong.");
    }
}
