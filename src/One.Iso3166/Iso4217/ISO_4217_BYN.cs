using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BYN()
    {
        Add(Country.BY, "Belarusian ruble", "BYN", 933, 2);
        Debug.Assert(_currenciesPerCountry[Country.BY].Count >= 1, $"{Country.BY} Number of currencies is wrong.");
    }
}
