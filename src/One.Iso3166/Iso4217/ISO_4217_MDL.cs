using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MDL()
    {
        Add(Country.MD, "Moldovan leu", "MDL", 498, 2);
        Debug.Assert(_currenciesPerCountry[Country.MD].Count >= 1, $"{Country.MD} Number of currencies is wrong.");
    }
}
