using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MNT()
    {
        Add(Country.MN, "Mongolian tögrög", "MNT", 496, 2);
        Debug.Assert(_currenciesPerCountry[Country.MN].Count >= 1, $"{Country.MN} Number of currencies is wrong.");
    }
}
