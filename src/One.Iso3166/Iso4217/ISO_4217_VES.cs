using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_VES()
    {
        Add(Country.VE, "Venezuelan sovereign bolívar", "VES", 928, 2);
        Debug.Assert(_currenciesPerCountry[Country.VE].Count >= 1, $"{Country.VE} Number of currencies is wrong.");
    }
}
