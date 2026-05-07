using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SZL()
    {
        Add(Country.SZ, "Swazi lilangeni", "SZL", 748, 2);
        Debug.Assert(_currenciesPerCountry[Country.SZ].Count >= 1, $"{Country.SZ} Number of currencies is wrong.");
    }
}
