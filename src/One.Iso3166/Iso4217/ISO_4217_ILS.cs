using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_ILS()
    {
        Add(Country.IL, "Israeli new shekel", "ILS", 376, 2);
        Debug.Assert(_currenciesPerCountry[Country.IL].Count >= 1, $"{Country.IL} Number of currencies is wrong.");
    }
}
