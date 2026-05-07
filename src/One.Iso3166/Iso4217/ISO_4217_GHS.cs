using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_GHS()
    {
        Add(Country.GH, "Ghanaian cedi", "GHS", 936, 2);
        Debug.Assert(_currenciesPerCountry[Country.GH].Count >= 1, $"{Country.GH} Number of currencies is wrong.");
    }
}
