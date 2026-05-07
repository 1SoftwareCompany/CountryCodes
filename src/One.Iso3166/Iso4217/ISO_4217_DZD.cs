using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_DZD()
    {
        Add(Country.DZ, "Algerian dinar", "DZD", 012, 2);
        Debug.Assert(_currenciesPerCountry[Country.DZ].Count >= 1, $"{Country.DZ} Number of currencies is wrong.");
    }
}
