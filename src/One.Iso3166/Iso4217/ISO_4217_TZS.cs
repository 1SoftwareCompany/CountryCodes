using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_TZS()
    {
        Add(Country.TZ, "Tanzanian shilling", "TZS", 834, 2);
        Debug.Assert(_currenciesPerCountry[Country.TZ].Count >= 1, $"{Country.TZ} Number of currencies is wrong.");
    }
}
