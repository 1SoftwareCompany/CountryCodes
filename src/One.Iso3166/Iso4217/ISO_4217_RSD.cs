using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_RSD()
    {
        Add(Country.RS, "Serbian dinar", "RSD", 941, 2);
        Debug.Assert(_currenciesPerCountry[Country.RS].Count >= 1, $"{Country.RS} Number of currencies is wrong.");
    }
}
