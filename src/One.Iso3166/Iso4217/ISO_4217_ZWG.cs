using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_ZWG()
    {
        Add(Country.ZW, "Zimbabwe Gold", "ZWG", 924, 2);
        Debug.Assert(_currenciesPerCountry[Country.ZW].Count >= 1, $"{Country.ZW} Number of currencies is wrong.");
    }
}
