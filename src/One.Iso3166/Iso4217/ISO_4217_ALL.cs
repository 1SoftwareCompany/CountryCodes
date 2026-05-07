using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_ALL()
    {
        Add(Country.AL, "Albanian lek", "ALL", 008, 2);

        Debug.Assert(_currenciesPerCountry[Country.AL].Count == 1, $"{Country.AL} Number of currencies is wrong.");
    }
}
