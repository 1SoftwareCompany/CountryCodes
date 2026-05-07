using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SBD()
    {
        Add(Country.SB, "Solomon Islands dollar", "SBD", 090, 2);
        Debug.Assert(_currenciesPerCountry[Country.SB].Count >= 1, $"{Country.SB} Number of currencies is wrong.");
    }
}
