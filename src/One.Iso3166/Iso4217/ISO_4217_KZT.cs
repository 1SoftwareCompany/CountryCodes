using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_KZT()
    {
        Add(Country.KZ, "Kazakhstani tenge", "KZT", 398, 2);
        Debug.Assert(_currenciesPerCountry[Country.KZ].Count >= 1, $"{Country.KZ} Number of currencies is wrong.");
    }
}
