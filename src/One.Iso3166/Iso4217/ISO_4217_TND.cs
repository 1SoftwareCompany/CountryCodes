using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_TND()
    {
        Add(Country.TN, "Tunisian dinar", "TND", 788, 3);
        Debug.Assert(_currenciesPerCountry[Country.TN].Count >= 1, $"{Country.TN} Number of currencies is wrong.");
    }
}
