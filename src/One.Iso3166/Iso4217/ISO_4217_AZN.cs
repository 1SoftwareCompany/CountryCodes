using System.Diagnostics;

namespace One.Iso3166.Iso4217
{

    public partial struct Currency
    {
        internal static void ISO_4217_AZN()
        {
            Add(Country.AZ, "Azerbaijani manat", "AZN", 944, 2);
            Debug.Assert(_currenciesPerCountry[Country.AZ].Count >= 1, $"{Country.AZ} Number of currencies is wrong.");
        }
    }

}
