using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SEK()
    {
        Add(Country.SE, "Swedish krona", "SEK", 752, 2);
        Debug.Assert(_currenciesPerCountry[Country.SE].Count >= 1, $"{Country.SE} Number of currencies is wrong.");
    }
}
