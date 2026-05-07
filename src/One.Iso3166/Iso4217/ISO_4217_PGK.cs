using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_PGK()
    {
        Add(Country.PG, "Papua New Guinean kina", "PGK", 598, 2);
        Debug.Assert(_currenciesPerCountry[Country.PG].Count >= 1, $"{Country.PG} Number of currencies is wrong.");
    }
}
