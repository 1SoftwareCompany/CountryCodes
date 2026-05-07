using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_SAR()
    {
        Add(Country.SA, "Saudi riyal", "SAR", 682, 2);
        Debug.Assert(_currenciesPerCountry[Country.SA].Count >= 1, $"{Country.SA} Number of currencies is wrong.");
    }
}
