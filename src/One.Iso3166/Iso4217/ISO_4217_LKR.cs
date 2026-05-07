using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_LKR()
    {
        Add(Country.LK, "Sri Lankan rupee", "LKR", 144, 2);
        Debug.Assert(_currenciesPerCountry[Country.LK].Count >= 1, $"{Country.LK} Number of currencies is wrong.");
    }
}
