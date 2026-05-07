using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_NOK()
    {
        Add(Country.BV, "Norwegian krone", "NOK", 578, 2);
        Debug.Assert(_currenciesPerCountry[Country.BV].Count >= 1, $"{Country.BV} Number of currencies is wrong.");

        Add(Country.NO, "Norwegian krone", "NOK", 578, 2);
        Debug.Assert(_currenciesPerCountry[Country.NO].Count >= 1, $"{Country.NO} Number of currencies is wrong.");

        Add(Country.SJ, "Norwegian krone", "NOK", 578, 2);
        Debug.Assert(_currenciesPerCountry[Country.SJ].Count >= 1, $"{Country.SJ} Number of currencies is wrong.");
    }
}
