using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_GEL()
    {
        Add(Country.GE, "Georgian lari", "GEL", 981, 2);
        Debug.Assert(_currenciesPerCountry[Country.GE].Count >= 1, $"{Country.GE} Number of currencies is wrong.");
    }
}
