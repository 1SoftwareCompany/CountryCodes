using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SVC()
    {
        Add(Country.SV, "Salvadoran colón", "SVC", 222, 2);
        Debug.Assert(_currenciesPerCountry[Country.SV].Count >= 1, $"{Country.SV} Number of currencies is wrong.");
    }
}
