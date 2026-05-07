using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_PEN()
    {
        Add(Country.PE, "Peruvian sol", "PEN", 604, 2);
        Debug.Assert(_currenciesPerCountry[Country.PE].Count >= 1, $"{Country.PE} Number of currencies is wrong.");
    }
}
