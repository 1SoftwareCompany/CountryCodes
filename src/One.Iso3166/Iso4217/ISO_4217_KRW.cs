using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_KRW()
    {
        Add(Country.KR, "South Korean won", "KRW", 410, 0);
        Debug.Assert(_currenciesPerCountry[Country.KR].Count >= 1, $"{Country.KR} Number of currencies is wrong.");
    }
}
