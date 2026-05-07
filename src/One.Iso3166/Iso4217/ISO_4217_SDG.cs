using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SDG()
    {
        Add(Country.SD, "Sudanese pound", "SDG", 938, 2);
        Debug.Assert(_currenciesPerCountry[Country.SD].Count >= 1, $"{Country.SD} Number of currencies is wrong.");
    }
}
