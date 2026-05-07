using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_ERN()
    {
        Add(Country.ER, "Eritrean nakfa", "ERN", 232, 2);
        Debug.Assert(_currenciesPerCountry[Country.ER].Count >= 1, $"{Country.ER} Number of currencies is wrong.");
    }
}
