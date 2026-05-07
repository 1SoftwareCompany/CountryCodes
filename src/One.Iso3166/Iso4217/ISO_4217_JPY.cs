using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_JPY()
    {
        Add(Country.JP, "Japanese yen", "JPY", 392, 0);
        Debug.Assert(_currenciesPerCountry[Country.JP].Count >= 1, $"{Country.JP} Number of currencies is wrong.");
    }
}
