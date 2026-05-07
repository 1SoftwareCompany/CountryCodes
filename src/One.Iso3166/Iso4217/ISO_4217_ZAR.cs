using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_ZAR()
    {
        Add(Country.LS, "South African rand", "ZAR", 710, 2);
        Debug.Assert(_currenciesPerCountry[Country.LS].Count >= 2, $"{Country.LS} Number of currencies is wrong.");

        Add(Country.NA, "South African rand", "ZAR", 710, 2);
        Debug.Assert(_currenciesPerCountry[Country.NA].Count >= 2, $"{Country.NA} Number of currencies is wrong.");

        Add(Country.SZ, "South African rand", "ZAR", 710, 2);
        Debug.Assert(_currenciesPerCountry[Country.SZ].Count >= 1, $"{Country.SZ} Number of currencies is wrong.");

        Add(Country.ZA, "South African rand", "ZAR", 710, 2);
        Debug.Assert(_currenciesPerCountry[Country.ZA].Count >= 1, $"{Country.ZA} Number of currencies is wrong.");
    }
}
