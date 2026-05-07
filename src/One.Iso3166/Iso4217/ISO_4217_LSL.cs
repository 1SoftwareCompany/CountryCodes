using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_LSL()
    {
        Add(Country.LS, "Lesotho loti", "LSL", 426, 2);
        Debug.Assert(_currenciesPerCountry[Country.LS].Count >= 1, $"{Country.LS} Number of currencies is wrong.");
    }
}
