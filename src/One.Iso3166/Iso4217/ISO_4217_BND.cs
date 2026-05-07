using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BND()
    {
        Add(Country.BN, "Brunei dollar", "BND", 096, 2);
        Debug.Assert(_currenciesPerCountry[Country.BN].Count >= 1, $"{Country.BN} Number of currencies is wrong.");
    }
}
