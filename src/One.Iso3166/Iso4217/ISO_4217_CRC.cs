using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CRC()
    {
        Add(Country.CR, "Costa Rican colón", "CRC", 188, 2);
        Debug.Assert(_currenciesPerCountry[Country.CR].Count >= 1, $"{Country.CR} Number of currencies is wrong.");
    }
}
