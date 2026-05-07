using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MWK()
    {
        Add(Country.MW, "Malawian kwacha", "MWK", 454, 2);
        Debug.Assert(_currenciesPerCountry[Country.MW].Count >= 1, $"{Country.MW} Number of currencies is wrong.");
    }
}
