using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BTN()
    {
        Add(Country.BT, "Bhutanese ngultrum", "BTN", 064, 2);
        Debug.Assert(_currenciesPerCountry[Country.BT].Count >= 1, $"{Country.BT} Number of currencies is wrong.");
    }
}
