using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_OMR()
    {
        Add(Country.OM, "Omani rial", "OMR", 512, 3);
        Debug.Assert(_currenciesPerCountry[Country.OM].Count >= 1, $"{Country.OM} Number of currencies is wrong.");
    }
}
