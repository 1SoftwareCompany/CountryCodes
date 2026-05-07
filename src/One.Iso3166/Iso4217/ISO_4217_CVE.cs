using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CVE()
    {
        Add(Country.CV, "Cape Verdean escudo", "CVE", 132, 2);
        Debug.Assert(_currenciesPerCountry[Country.CV].Count >= 1, $"{Country.CV} Number of currencies is wrong.");
    }
}
