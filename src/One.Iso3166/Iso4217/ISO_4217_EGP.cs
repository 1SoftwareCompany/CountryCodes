using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_EGP()
    {
        Add(Country.EG, "Egyptian pound", "EGP", 818, 2);
        Debug.Assert(_currenciesPerCountry[Country.EG].Count >= 1, $"{Country.EG} Number of currencies is wrong.");
    }
}
