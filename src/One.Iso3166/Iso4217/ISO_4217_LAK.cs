using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_LAK()
    {
        Add(Country.LA, "Lao kip", "LAK", 418, 2);
        Debug.Assert(_currenciesPerCountry[Country.LA].Count >= 1, $"{Country.LA} Number of currencies is wrong.");
    }
}
