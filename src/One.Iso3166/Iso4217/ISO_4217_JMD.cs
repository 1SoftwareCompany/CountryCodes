using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_JMD()
    {
        Add(Country.JM, "Jamaican dollar", "JMD", 388, 2);
        Debug.Assert(_currenciesPerCountry[Country.JM].Count >= 1, $"{Country.JM} Number of currencies is wrong.");
    }
}
