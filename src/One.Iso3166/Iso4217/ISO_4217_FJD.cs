using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_FJD()
    {
        Add(Country.FJ, "Fijian dollar", "FJD", 242, 2);
        Debug.Assert(_currenciesPerCountry[Country.FJ].Count >= 1, $"{Country.FJ} Number of currencies is wrong.");
    }
}
