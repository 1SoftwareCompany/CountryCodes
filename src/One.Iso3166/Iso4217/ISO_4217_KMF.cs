using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_KMF()
    {
        Add(Country.KM, "Comoro franc", "KMF", 174, 0);
        Debug.Assert(_currenciesPerCountry[Country.KM].Count >= 1, $"{Country.KM} Number of currencies is wrong.");
    }
}
