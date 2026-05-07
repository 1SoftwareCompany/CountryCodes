using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_LBP()
    {
        Add(Country.LB, "Lebanese pound", "LBP", 422, 2);
        Debug.Assert(_currenciesPerCountry[Country.LB].Count >= 1, $"{Country.LB} Number of currencies is wrong.");
    }
}
