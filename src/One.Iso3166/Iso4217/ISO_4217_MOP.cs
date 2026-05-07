using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MOP()
    {
        Add(Country.MO, "Macanese pataca", "MOP", 446, 2);
        Debug.Assert(_currenciesPerCountry[Country.MO].Count >= 1, $"{Country.MO} Number of currencies is wrong.");
    }
}
