using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BHD()
    {
        Add(Country.BH, "Bahraini dinar", "BHD", 048, 3);
        Debug.Assert(_currenciesPerCountry[Country.BH].Count >= 1, $"{Country.BH} Number of currencies is wrong.");
    }
}
