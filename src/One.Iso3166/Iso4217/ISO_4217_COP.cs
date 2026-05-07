using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_COP()
    {
        Add(Country.CO, "Colombian peso", "COP", 170, 2);
        Debug.Assert(_currenciesPerCountry[Country.CO].Count >= 1, $"{Country.CO} Number of currencies is wrong.");
    }
}
