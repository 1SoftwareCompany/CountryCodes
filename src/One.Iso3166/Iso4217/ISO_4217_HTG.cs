using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_HTG()
    {
        Add(Country.HT, "Haitian gourde", "HTG", 332, 2);
        Debug.Assert(_currenciesPerCountry[Country.HT].Count >= 1, $"{Country.HT} Number of currencies is wrong.");
    }
}
