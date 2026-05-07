using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_ISK()
    {
        Add(Country.IS, "Icelandic króna", "ISK", 352, 0);
        Debug.Assert(_currenciesPerCountry[Country.IS].Count >= 1, $"{Country.IS} Number of currencies is wrong.");
    }
}
