using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_ARS()
    {
        Add(Country.AR, "Argentine peso", "ARS", 032, 2);

        Debug.Assert(_currenciesPerCountry[Country.AR].Count >= 1, $"{Country.AR} Number of currencies is wrong.");
    }
}
