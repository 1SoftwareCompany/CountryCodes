using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_TJS()
    {
        Add(Country.TJ, "Tajikistani somoni", "TJS", 972, 2);
        Debug.Assert(_currenciesPerCountry[Country.TJ].Count >= 1, $"{Country.TJ} Number of currencies is wrong.");
    }
}
