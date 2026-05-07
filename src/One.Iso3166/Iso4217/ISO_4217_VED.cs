using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_VED()
    {
        Add(Country.VE, "Venezuelan digital bolívar", "VED", 926, 2);
        Debug.Assert(_currenciesPerCountry[Country.VE].Count >= 2, $"{Country.VE} Number of currencies is wrong.");
    }
}
