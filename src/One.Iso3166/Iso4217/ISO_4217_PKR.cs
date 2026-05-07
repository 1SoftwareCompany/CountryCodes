using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_PKR()
    {
        Add(Country.PK, "Pakistani rupee", "PKR", 586, 2);
        Debug.Assert(_currenciesPerCountry[Country.PK].Count >= 1, $"{Country.PK} Number of currencies is wrong.");
    }
}
