using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SLE()
    {
        Add(Country.SL, "Sierra Leonean leone", "SLE", 925, 2);
        Debug.Assert(_currenciesPerCountry[Country.SL].Count >= 1, $"{Country.SL} Number of currencies is wrong.");
    }
}
