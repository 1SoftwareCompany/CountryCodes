using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_VND()
    {
        Add(Country.VN, "Vietnamese đồng", "VND", 704, 0);
        Debug.Assert(_currenciesPerCountry[Country.VN].Count >= 1, $"{Country.VN} Number of currencies is wrong.");
    }
}
