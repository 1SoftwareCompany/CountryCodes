using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_AMD()
    {
        Add(Country.AM, "Armenian dram", "AMD", 051, 2);

        Debug.Assert(_currenciesPerCountry[Country.AM].Count >= 1, $"{Country.AM} Number of currencies is wrong.");
    }
}
