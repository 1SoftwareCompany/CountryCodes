using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_FKP()
    {
        Add(Country.FK, "Falkland Islands pound", "FKP", 238, 2);
        Debug.Assert(_currenciesPerCountry[Country.FK].Count >= 1, $"{Country.FK} Number of currencies is wrong.");
    }
}
