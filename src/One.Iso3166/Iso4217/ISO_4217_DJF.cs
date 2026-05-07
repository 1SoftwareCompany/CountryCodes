using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_DJF()
    {
        Add(Country.DJ, "Djiboutian franc", "DJF", 262, 0);
        Debug.Assert(_currenciesPerCountry[Country.DJ].Count >= 1, $"{Country.DJ} Number of currencies is wrong.");
    }
}
