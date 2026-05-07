using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_ZMW()
    {
        Add(Country.ZM, "Zambian kwacha", "ZMW", 967, 2);
        Debug.Assert(_currenciesPerCountry[Country.ZM].Count >= 1, $"{Country.ZM} Number of currencies is wrong.");
    }
}
