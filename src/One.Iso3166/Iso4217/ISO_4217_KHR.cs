using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_KHR()
    {
        Add(Country.KH, "Cambodian riel", "KHR", 116, 2);
        Debug.Assert(_currenciesPerCountry[Country.KH].Count >= 1, $"{Country.KH} Number of currencies is wrong.");
    }
}
