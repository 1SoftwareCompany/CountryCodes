using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_HKD()
    {
        Add(Country.HK, "Hong Kong dollar", "HKD", 344, 2);
        Debug.Assert(_currenciesPerCountry[Country.HK].Count >= 1, $"{Country.HK} Number of currencies is wrong.");
    }
}
