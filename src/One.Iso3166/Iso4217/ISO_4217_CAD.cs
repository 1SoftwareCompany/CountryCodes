using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CAD()
    {
        Add(Country.CA, "Canadian dollar", "CAD", 124, 2);
        Debug.Assert(_currenciesPerCountry[Country.CA].Count >= 1, $"{Country.CA} Number of currencies is wrong.");
    }
}
