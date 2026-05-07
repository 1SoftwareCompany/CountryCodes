using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_USN()
    {
        Add(Country.US, "United States dollar (next day)", "USN", 997, 2);
        Debug.Assert(_currenciesPerCountry[Country.US].Count >= 1, $"{Country.US} Number of currencies is wrong.");
    }
}
