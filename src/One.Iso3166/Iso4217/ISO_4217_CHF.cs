using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CHF()
    {
        Add(Country.CH, "Swiss franc", "CHF", 756, 2);
        Debug.Assert(_currenciesPerCountry[Country.CH].Count >= 1, $"{Country.CH} Number of currencies is wrong.");

        Add(Country.LI, "Swiss franc", "CHF", 756, 2);
        Debug.Assert(_currenciesPerCountry[Country.LI].Count >= 1, $"{Country.LI} Number of currencies is wrong.");
    }
}
