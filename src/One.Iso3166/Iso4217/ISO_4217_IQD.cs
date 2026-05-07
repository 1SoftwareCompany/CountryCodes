using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_IQD()
    {
        Add(Country.IQ, "Iraqi dinar", "IQD", 368, 3);
        Debug.Assert(_currenciesPerCountry[Country.IQ].Count >= 1, $"{Country.IQ} Number of currencies is wrong.");
    }
}
