using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MGA()
    {
        Add(Country.MG, "Malagasy ariary", "MGA", 969, 2);
        Debug.Assert(_currenciesPerCountry[Country.MG].Count >= 1, $"{Country.MG} Number of currencies is wrong.");
    }
}
