using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_PHP()
    {
        Add(Country.PH, "Philippine peso", "PHP", 608, 2);
        Debug.Assert(_currenciesPerCountry[Country.PH].Count >= 1, $"{Country.PH} Number of currencies is wrong.");
    }
}
