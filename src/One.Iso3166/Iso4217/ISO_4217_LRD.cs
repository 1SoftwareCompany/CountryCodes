using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_LRD()
    {
        Add(Country.LR, "Liberian dollar", "LRD", 430, 2);
        Debug.Assert(_currenciesPerCountry[Country.LR].Count >= 1, $"{Country.LR} Number of currencies is wrong.");
    }
}
