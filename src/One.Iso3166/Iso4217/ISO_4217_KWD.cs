using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_KWD()
    {
        Add(Country.KW, "Kuwaiti dinar", "KWD", 414, 3);
        Debug.Assert(_currenciesPerCountry[Country.KW].Count >= 1, $"{Country.KW} Number of currencies is wrong.");
    }
}
