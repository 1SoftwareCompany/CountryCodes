using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CUP()
    {
        Add(Country.CU, "Cuban peso", "CUP", 192, 2);
        Debug.Assert(_currenciesPerCountry[Country.CU].Count >= 1, $"{Country.CU} Number of currencies is wrong.");
    }
}
