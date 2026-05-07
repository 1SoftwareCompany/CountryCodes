using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MVR()
    {
        Add(Country.MV, "Maldivian rufiyaa", "MVR", 462, 2);
        Debug.Assert(_currenciesPerCountry[Country.MV].Count >= 1, $"{Country.MV} Number of currencies is wrong.");
    }
}
