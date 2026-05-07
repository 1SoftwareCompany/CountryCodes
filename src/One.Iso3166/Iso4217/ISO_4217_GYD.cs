using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_GYD()
    {
        Add(Country.GY, "Guyanese dollar", "GYD", 328, 2);
        Debug.Assert(_currenciesPerCountry[Country.GY].Count >= 1, $"{Country.GY} Number of currencies is wrong.");
    }
}
