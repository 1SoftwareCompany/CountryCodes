using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_KES()
    {
        Add(Country.KE, "Kenyan shilling", "KES", 404, 2);
        Debug.Assert(_currenciesPerCountry[Country.KE].Count >= 1, $"{Country.KE} Number of currencies is wrong.");
    }
}
