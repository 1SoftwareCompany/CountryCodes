using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_GNF()
    {
        Add(Country.GN, "Guinean franc", "GNF", 324, 0);
        Debug.Assert(_currenciesPerCountry[Country.GN].Count >= 1, $"{Country.GN} Number of currencies is wrong.");
    }
}
