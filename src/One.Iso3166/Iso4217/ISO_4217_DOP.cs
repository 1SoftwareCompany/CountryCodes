using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_DOP()
    {
        Add(Country.DO, "Dominican peso", "DOP", 214, 2);
        Debug.Assert(_currenciesPerCountry[Country.DO].Count >= 1, $"{Country.DO} Number of currencies is wrong.");
    }
}
