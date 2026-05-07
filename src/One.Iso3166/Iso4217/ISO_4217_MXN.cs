using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MXN()
    {
        Add(Country.MX, "Mexican peso", "MXN", 484, 2);
        Debug.Assert(_currenciesPerCountry[Country.MX].Count >= 1, $"{Country.MX} Number of currencies is wrong.");
    }
}
