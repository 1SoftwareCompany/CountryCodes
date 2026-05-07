using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BDT()
    {
        Add(Country.BD, "Bangladeshi taka", "BDT", 050, 2);
        Debug.Assert(_currenciesPerCountry[Country.BD].Count >= 1, $"{Country.BD} Number of currencies is wrong.");
    }
}
