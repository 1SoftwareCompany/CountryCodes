using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_BOV()
    {
        Add(Country.BO, "Bolivian Mvdol (funds code)", "BOV", 984, 2);
        Debug.Assert(_currenciesPerCountry[Country.BO].Count >= 2, $"{Country.BO} Number of currencies is wrong.");
    }
}
