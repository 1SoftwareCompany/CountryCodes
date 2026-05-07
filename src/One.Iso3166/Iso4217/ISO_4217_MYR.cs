using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MYR()
    {
        Add(Country.MY, "Malaysian ringgit", "MYR", 458, 2);
        Debug.Assert(_currenciesPerCountry[Country.MY].Count >= 1, $"{Country.MY} Number of currencies is wrong.");
    }
}
