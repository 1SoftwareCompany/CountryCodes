using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_KPW()
    {
        Add(Country.KP, "North Korean won", "KPW", 408, 2);
        Debug.Assert(_currenciesPerCountry[Country.KP].Count >= 1, $"{Country.KP} Number of currencies is wrong.");
    }
}
