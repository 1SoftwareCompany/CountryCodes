using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_HUF()
    {
        Add(Country.HU, "Hungarian forint", "HUF", 348, 2);
        Debug.Assert(_currenciesPerCountry[Country.HU].Count >= 1, $"{Country.HU} Number of currencies is wrong.");
    }
}
