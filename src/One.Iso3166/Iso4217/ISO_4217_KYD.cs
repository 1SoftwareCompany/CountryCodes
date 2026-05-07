using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_KYD()
    {
        Add(Country.KY, "Cayman Islands dollar", "KYD", 136, 2);
        Debug.Assert(_currenciesPerCountry[Country.KY].Count >= 1, $"{Country.KY} Number of currencies is wrong.");
    }
}
