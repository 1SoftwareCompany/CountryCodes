using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SGD()
    {
        Add(Country.SG, "Singapore dollar", "SGD", 702, 2);
        Debug.Assert(_currenciesPerCountry[Country.SG].Count >= 1, $"{Country.SG} Number of currencies is wrong.");
    }
}
