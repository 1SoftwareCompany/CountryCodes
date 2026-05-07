using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_IRR()
    {
        Add(Country.IR, "Iranian rial", "IRR", 364, 2);
        Debug.Assert(_currenciesPerCountry[Country.IR].Count >= 1, $"{Country.IR} Number of currencies is wrong.");
    }
}
