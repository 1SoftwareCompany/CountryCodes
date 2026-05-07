using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BMD()
    {
        Add(Country.BM, "Bermudian dollar", "BMD", 060, 2);
        Debug.Assert(_currenciesPerCountry[Country.BM].Count >= 1, $"{Country.BM} Number of currencies is wrong.");
    }
}
