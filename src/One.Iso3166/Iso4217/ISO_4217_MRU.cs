using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MRU()
    {
        Add(Country.MR, "Mauritanian ouguiya", "MRU", 929, 2);
        Debug.Assert(_currenciesPerCountry[Country.MR].Count >= 1, $"{Country.MR} Number of currencies is wrong.");
    }
}
