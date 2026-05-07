using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_STN()
    {
        Add(Country.ST, "São Tomé and Príncipe dobra", "STN", 930, 2);
        Debug.Assert(_currenciesPerCountry[Country.ST].Count >= 1, $"{Country.ST} Number of currencies is wrong.");
    }
}
