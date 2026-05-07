using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_PAB()
    {
        Add(Country.PA, "Panamanian balboa", "PAB", 590, 2);
        Debug.Assert(_currenciesPerCountry[Country.PA].Count >= 1, $"{Country.PA} Number of currencies is wrong.");
    }
}
