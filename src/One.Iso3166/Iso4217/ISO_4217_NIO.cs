using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_NIO()
    {
        Add(Country.NI, "Nicaraguan córdoba", "NIO", 558, 2);
        Debug.Assert(_currenciesPerCountry[Country.NI].Count >= 1, $"{Country.NI} Number of currencies is wrong.");
    }
}
