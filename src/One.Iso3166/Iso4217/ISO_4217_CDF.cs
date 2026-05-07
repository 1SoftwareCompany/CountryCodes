using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CDF()
    {
        Add(Country.CD, "Congolese franc", "CDF", 976, 2);
        Debug.Assert(_currenciesPerCountry[Country.CD].Count >= 1, $"{Country.CD} Number of currencies is wrong.");
    }
}
