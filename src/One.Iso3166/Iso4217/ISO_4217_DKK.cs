using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_DKK()
    {
        Add(Country.DK, "Danish krone", "DKK", 208, 2);
        Debug.Assert(_currenciesPerCountry[Country.DK].Count >= 1, $"{Country.DK} Number of currencies is wrong.");

        Add(Country.FO, "Danish krone", "DKK", 208, 2);
        Debug.Assert(_currenciesPerCountry[Country.FO].Count >= 1, $"{Country.FO} Number of currencies is wrong.");

        Add(Country.GL, "Danish krone", "DKK", 208, 2);
        Debug.Assert(_currenciesPerCountry[Country.GL].Count >= 1, $"{Country.GL} Number of currencies is wrong.");
    }
}
