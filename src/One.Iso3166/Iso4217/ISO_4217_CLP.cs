using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CLP()
    {
        Add(Country.CL, "Chilean peso", "CLP", 152, 0);
        Debug.Assert(_currenciesPerCountry[Country.CL].Count >= 1, $"{Country.CL} Number of currencies is wrong.");
    }
}
