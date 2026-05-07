using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_IDR()
    {
        Add(Country.ID, "Indonesian rupiah", "IDR", 360, 2);
        Debug.Assert(_currenciesPerCountry[Country.ID].Count >= 1, $"{Country.ID} Number of currencies is wrong.");
    }
}
