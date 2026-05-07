using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CNY()
    {
        Add(Country.CN, "Chinese yuan", "CNY", 156, 2);
        Debug.Assert(_currenciesPerCountry[Country.CN].Count >= 1, $"{Country.CN} Number of currencies is wrong.");
    }
}
