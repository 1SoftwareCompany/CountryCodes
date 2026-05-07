using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BIF()
    {
        Add(Country.BI, "Burundian franc", "BIF", 108, 0);
        Debug.Assert(_currenciesPerCountry[Country.BI].Count >= 1, $"{Country.BI} Number of currencies is wrong.");
    }
}
