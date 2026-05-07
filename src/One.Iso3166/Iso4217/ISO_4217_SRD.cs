using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SRD()
    {
        Add(Country.SR, "Surinamese dollar", "SRD", 968, 2);
        Debug.Assert(_currenciesPerCountry[Country.SR].Count >= 1, $"{Country.SR} Number of currencies is wrong.");
    }
}
