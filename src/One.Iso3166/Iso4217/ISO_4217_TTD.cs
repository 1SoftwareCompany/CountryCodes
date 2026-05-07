using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_TTD()
    {
        Add(Country.TT, "Trinidad and Tobago dollar", "TTD", 780, 2);
        Debug.Assert(_currenciesPerCountry[Country.TT].Count >= 1, $"{Country.TT} Number of currencies is wrong.");
    }
}
