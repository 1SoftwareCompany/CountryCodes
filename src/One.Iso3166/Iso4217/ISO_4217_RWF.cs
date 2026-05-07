using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_RWF()
    {
        Add(Country.RW, "Rwandan franc", "RWF", 646, 0);
        Debug.Assert(_currenciesPerCountry[Country.RW].Count >= 1, $"{Country.RW} Number of currencies is wrong.");
    }
}
