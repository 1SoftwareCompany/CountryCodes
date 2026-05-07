using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SYP()
    {
        Add(Country.SY, "Syrian pound", "SYP", 760, 2);
        Debug.Assert(_currenciesPerCountry[Country.SY].Count >= 1, $"{Country.SY} Number of currencies is wrong.");
    }
}
