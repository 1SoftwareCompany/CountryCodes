using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_PLN()
    {
        Add(Country.PL, "Polish złoty", "PLN", 985, 2);
        Debug.Assert(_currenciesPerCountry[Country.PL].Count >= 1, $"{Country.PL} Number of currencies is wrong.");
    }
}
