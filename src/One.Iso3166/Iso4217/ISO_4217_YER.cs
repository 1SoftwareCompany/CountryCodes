using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_YER()
    {
        Add(Country.YE, "Yemeni rial", "YER", 886, 2);
        Debug.Assert(_currenciesPerCountry[Country.YE].Count >= 1, $"{Country.YE} Number of currencies is wrong.");
    }
}
