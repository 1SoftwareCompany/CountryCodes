using System.Diagnostics;

namespace One.Iso3166.Iso4217
{
    public partial struct Currency
    {
        internal static void ISO_4217_BBD()
        {
            Add(Country.BB, "Barbadian dollar", "BBD", 052, 2);
            Debug.Assert(_currenciesPerCountry[Country.BB].Count >= 1, $"{Country.BB} Number of currencies is wrong.");
        }
    }
}
