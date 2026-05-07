using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_GIP()
    {
        Add(Country.GI, "Gibraltar pound", "GIP", 292, 2);
        Debug.Assert(_currenciesPerCountry[Country.GI].Count >= 1, $"{Country.GI} Number of currencies is wrong.");
    }
}
