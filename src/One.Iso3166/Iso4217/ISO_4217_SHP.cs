using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SHP()
    {
        Add(Country.SH, "Saint Helena pound", "SHP", 654, 2);
        Debug.Assert(_currenciesPerCountry[Country.SH].Count >= 2, $"{Country.SH} Number of currencies is wrong.");
    }
}
