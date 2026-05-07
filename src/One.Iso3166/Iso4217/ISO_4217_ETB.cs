using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_ETB()
    {
        Add(Country.ET, "Ethiopian birr", "ETB", 230, 2);
        Debug.Assert(_currenciesPerCountry[Country.ET].Count >= 1, $"{Country.ET} Number of currencies is wrong.");
    }
}
