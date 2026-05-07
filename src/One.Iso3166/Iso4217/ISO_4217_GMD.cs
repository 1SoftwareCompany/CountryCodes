using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_GMD()
    {
        Add(Country.GM, "Gambian dalasi", "GMD", 270, 2);
        Debug.Assert(_currenciesPerCountry[Country.GM].Count >= 1, $"{Country.GM} Number of currencies is wrong.");
    }
}
