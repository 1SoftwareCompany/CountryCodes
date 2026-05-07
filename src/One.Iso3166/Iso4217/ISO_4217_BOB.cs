using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BOB()
    {
        Add(Country.BO, "Boliviano", "BOB", 068, 2);
        Debug.Assert(_currenciesPerCountry[Country.BO].Count >= 1, $"{Country.BO} Number of currencies is wrong.");
    }
}
