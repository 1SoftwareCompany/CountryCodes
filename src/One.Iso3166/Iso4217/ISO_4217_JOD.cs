using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_JOD()
    {
        Add(Country.JO, "Jordanian dinar", "JOD", 400, 3);
        Debug.Assert(_currenciesPerCountry[Country.JO].Count >= 1, $"{Country.JO} Number of currencies is wrong.");
    }
}
