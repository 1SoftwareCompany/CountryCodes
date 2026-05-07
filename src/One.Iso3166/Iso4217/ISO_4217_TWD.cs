using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_TWD()
    {
        Add(Country.TW, "New Taiwan dollar", "TWD", 901, 2);
        Debug.Assert(_currenciesPerCountry[Country.TW].Count >= 1, $"{Country.TW} Number of currencies is wrong.");
    }
}
