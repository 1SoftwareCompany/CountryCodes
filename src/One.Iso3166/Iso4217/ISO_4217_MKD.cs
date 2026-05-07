using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MKD()
    {
        Add(Country.MK, "Macedonian denar", "MKD", 807, 2);
        Debug.Assert(_currenciesPerCountry[Country.MK].Count >= 1, $"{Country.MK} Number of currencies is wrong.");
    }
}
