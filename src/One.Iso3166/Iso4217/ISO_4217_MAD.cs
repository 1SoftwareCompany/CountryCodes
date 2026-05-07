using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MAD()
    {
        Add(Country.EH, "Moroccan dirham", "MAD", 504, 2);
        Debug.Assert(_currenciesPerCountry[Country.EH].Count >= 1, $"{Country.EH} Number of currencies is wrong.");

        Add(Country.MA, "Moroccan dirham", "MAD", 504, 2);
        Debug.Assert(_currenciesPerCountry[Country.MA].Count >= 1, $"{Country.MA} Number of currencies is wrong.");
    }
}
