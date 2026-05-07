using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_NAD()
    {
        Add(Country.NA, "Namibian dollar", "NAD", 516, 2);
        Debug.Assert(_currenciesPerCountry[Country.NA].Count >= 1, $"{Country.NA} Number of currencies is wrong.");
    }
}
