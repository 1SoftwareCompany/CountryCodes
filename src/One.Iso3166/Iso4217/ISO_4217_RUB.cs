using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_RUB()
    {
        Add(Country.RU, "Russian ruble", "RUB", 643, 2);
        Debug.Assert(_currenciesPerCountry[Country.RU].Count >= 1, $"{Country.RU} Number of currencies is wrong.");
    }
}
