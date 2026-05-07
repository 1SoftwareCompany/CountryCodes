using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MUR()
    {
        Add(Country.MU, "Mauritian rupee", "MUR", 480, 2);
        Debug.Assert(_currenciesPerCountry[Country.MU].Count >= 1, $"{Country.MU} Number of currencies is wrong.");
    }
}
