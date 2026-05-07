using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BWP()
    {
        Add(Country.BW, "Botswana pula", "BWP", 072, 2);
        Debug.Assert(_currenciesPerCountry[Country.BW].Count >= 1, $"{Country.BW} Number of currencies is wrong.");
    }
}
