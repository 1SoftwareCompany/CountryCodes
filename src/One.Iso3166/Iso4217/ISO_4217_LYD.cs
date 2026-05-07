using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_LYD()
    {
        Add(Country.LY, "Libyan dinar", "LYD", 434, 3);
        Debug.Assert(_currenciesPerCountry[Country.LY].Count >= 1, $"{Country.LY} Number of currencies is wrong.");
    }
}
