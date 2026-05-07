using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_NPR()
    {
        Add(Country.NP, "Nepalese rupee", "NPR", 524, 2);
        Debug.Assert(_currenciesPerCountry[Country.NP].Count >= 1, $"{Country.NP} Number of currencies is wrong.");
    }
}
