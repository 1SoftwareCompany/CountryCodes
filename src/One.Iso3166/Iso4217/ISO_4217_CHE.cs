using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CHE()
    {
        Add(Country.CH, "WIR euro (complementary currency)", "CHE", 947, 2);
        Debug.Assert(_currenciesPerCountry[Country.CH].Count >= 2, $"{Country.CH} Number of currencies is wrong.");
    }
}
