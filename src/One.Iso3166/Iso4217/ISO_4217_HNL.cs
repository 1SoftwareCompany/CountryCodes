using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_HNL()
    {
        Add(Country.HN, "Honduran lempira", "HNL", 340, 2);
        Debug.Assert(_currenciesPerCountry[Country.HN].Count >= 1, $"{Country.HN} Number of currencies is wrong.");
    }
}
