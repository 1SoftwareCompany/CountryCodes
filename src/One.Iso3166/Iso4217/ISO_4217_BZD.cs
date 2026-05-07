using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BZD()
    {
        Add(Country.BZ, "Belize dollar", "BZD", 084, 2);
        Debug.Assert(_currenciesPerCountry[Country.BZ].Count >= 1, $"{Country.BZ} Number of currencies is wrong.");
    }
}
