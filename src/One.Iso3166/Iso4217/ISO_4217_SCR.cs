using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SCR()
    {
        Add(Country.SC, "Seychellois rupee", "SCR", 690, 2);
        Debug.Assert(_currenciesPerCountry[Country.SC].Count >= 1, $"{Country.SC} Number of currencies is wrong.");
    }
}
