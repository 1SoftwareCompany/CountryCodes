using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SOS()
    {
        Add(Country.SO, "Somalian shilling", "SOS", 706, 2);
        Debug.Assert(_currenciesPerCountry[Country.SO].Count >= 1, $"{Country.SO} Number of currencies is wrong.");
    }
}
