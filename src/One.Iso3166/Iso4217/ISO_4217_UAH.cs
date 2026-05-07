using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_UAH()
    {
        Add(Country.UA, "Ukrainian hryvnia", "UAH", 980, 2);
        Debug.Assert(_currenciesPerCountry[Country.UA].Count >= 1, $"{Country.UA} Number of currencies is wrong.");
    }
}
