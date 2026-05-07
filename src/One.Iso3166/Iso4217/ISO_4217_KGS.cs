using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_KGS()
    {
        Add(Country.KG, "Kyrgyzstani som", "KGS", 417, 2);
        Debug.Assert(_currenciesPerCountry[Country.KG].Count >= 1, $"{Country.KG} Number of currencies is wrong.");
    }
}
