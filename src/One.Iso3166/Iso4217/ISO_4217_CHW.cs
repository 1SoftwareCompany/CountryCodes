using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CHW()
    {
        Add(Country.CH, "WIR franc (complementary currency)", "CHW", 948, 2);
        Debug.Assert(_currenciesPerCountry[Country.CH].Count >= 3, $"{Country.CH} Number of currencies is wrong.");
    }
}
