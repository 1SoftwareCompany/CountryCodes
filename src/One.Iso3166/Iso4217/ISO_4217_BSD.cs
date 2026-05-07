using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BSD()
    {
        Add(Country.BS, "Bahamian dollar", "BSD", 044, 2);
        Debug.Assert(_currenciesPerCountry[Country.BS].Count >= 1, $"{Country.BS} Number of currencies is wrong.");
    }
}
