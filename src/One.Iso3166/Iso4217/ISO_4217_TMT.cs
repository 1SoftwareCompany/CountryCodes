using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_TMT()
    {
        Add(Country.TM, "Turkmenistan manat", "TMT", 934, 2);
        Debug.Assert(_currenciesPerCountry[Country.TM].Count >= 1, $"{Country.TM} Number of currencies is wrong.");
    }
}
