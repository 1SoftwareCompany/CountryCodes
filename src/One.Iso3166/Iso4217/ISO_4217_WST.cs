using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_WST()
    {
        Add(Country.WS, "Samoan tālā", "WST", 882, 2);
        Debug.Assert(_currenciesPerCountry[Country.WS].Count >= 1, $"{Country.WS} Number of currencies is wrong.");
    }
}
