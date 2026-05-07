using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_UGX()
    {
        Add(Country.UG, "Ugandan shilling", "UGX", 800, 0);
        Debug.Assert(_currenciesPerCountry[Country.UG].Count >= 1, $"{Country.UG} Number of currencies is wrong.");
    }
}
