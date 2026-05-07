using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_RON()
    {
        Add(Country.RO, "Romanian leu", "RON", 946, 2);
        Debug.Assert(_currenciesPerCountry[Country.RO].Count >= 1, $"{Country.RO} Number of currencies is wrong.");
    }
}
