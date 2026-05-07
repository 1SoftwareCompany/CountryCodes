using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_UYW()
    {
        Add(Country.UY, "Unidad previsional", "UYW", 927, 4);
        Debug.Assert(_currenciesPerCountry[Country.UY].Count >= 2, $"{Country.UY} Number of currencies is wrong.");
    }
}
