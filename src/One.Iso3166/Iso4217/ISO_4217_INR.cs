using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_INR()
    {
        Add(Country.BT, "Indian rupee", "INR", 356, 2);
        Debug.Assert(_currenciesPerCountry[Country.BT].Count >= 1, $"{Country.BT} Number of currencies is wrong.");

        Add(Country.IN, "Indian rupee", "INR", 356, 2);
        Debug.Assert(_currenciesPerCountry[Country.IN].Count >= 1, $"{Country.IN} Number of currencies is wrong.");
    }
}
