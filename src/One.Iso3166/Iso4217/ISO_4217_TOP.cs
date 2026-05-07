using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_TOP()
    {
        Add(Country.TO, "Tongan paʻanga", "TOP", 776, 2);
        Debug.Assert(_currenciesPerCountry[Country.TO].Count >= 1, $"{Country.TO} Number of currencies is wrong.");
    }
}
