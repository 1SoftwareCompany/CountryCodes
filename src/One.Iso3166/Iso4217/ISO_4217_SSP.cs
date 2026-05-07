using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SSP()
    {
        Add(Country.SS, "South Sudanese pound", "SSP", 728, 2);
        Debug.Assert(_currenciesPerCountry[Country.SS].Count >= 1, $"{Country.SS} Number of currencies is wrong.");
    }
}
