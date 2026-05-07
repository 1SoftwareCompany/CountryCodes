using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_GTQ()
    {
        Add(Country.GT, "Guatemalan quetzal", "GTQ", 320, 2);
        Debug.Assert(_currenciesPerCountry[Country.GT].Count >= 1, $"{Country.GT} Number of currencies is wrong.");
    }
}
