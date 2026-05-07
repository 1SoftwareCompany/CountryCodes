using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_NGN()
    {
        Add(Country.NG, "Nigerian naira", "NGN", 566, 2);
        Debug.Assert(_currenciesPerCountry[Country.NG].Count >= 1, $"{Country.NG} Number of currencies is wrong.");
    }
}
