using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BRL()
    {
        Add(Country.BR, "Brazilian real", "BRL", 986, 2);
        Debug.Assert(_currenciesPerCountry[Country.BR].Count >= 1, $"{Country.BR} Number of currencies is wrong.");
    }
}
