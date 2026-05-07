using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_TRY()
    {
        Add(Country.TR, "Turkish lira", "TRY", 949, 2);
        Debug.Assert(_currenciesPerCountry[Country.TR].Count >= 1, $"{Country.TR} Number of currencies is wrong.");
    }
}
