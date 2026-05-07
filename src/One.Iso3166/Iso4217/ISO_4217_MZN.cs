using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MZN()
    {
        Add(Country.MZ, "Mozambican metical", "MZN", 943, 2);
        Debug.Assert(_currenciesPerCountry[Country.MZ].Count >= 1, $"{Country.MZ} Number of currencies is wrong.");
    }
}
