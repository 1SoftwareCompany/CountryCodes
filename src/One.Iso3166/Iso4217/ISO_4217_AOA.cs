using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_AOA()
    {
        Add(Country.AO, "Angolan kwanza", "AOA", 973, 2);

        Debug.Assert(_currenciesPerCountry[Country.AO].Count >= 1, $"{Country.AO} Number of currencies is wrong.");
    }
}
