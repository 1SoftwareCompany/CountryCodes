using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_UZS()
    {
        Add(Country.UZ, "Uzbekistani soʻm", "UZS", 860, 2);
        Debug.Assert(_currenciesPerCountry[Country.UZ].Count >= 1, $"{Country.UZ} Number of currencies is wrong.");
    }
}
