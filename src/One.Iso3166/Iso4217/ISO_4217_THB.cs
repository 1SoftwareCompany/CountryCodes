using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_THB()
    {
        Add(Country.TH, "Thai baht", "THB", 764, 2);
        Debug.Assert(_currenciesPerCountry[Country.TH].Count >= 1, $"{Country.TH} Number of currencies is wrong.");
    }
}
