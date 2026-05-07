using System.Diagnostics;

namespace One.Iso3166.Iso4217
{
    public partial struct Currency
    {
        internal static void ISO_4217_UYI()
        {
            Add(Country.UY, "Uruguayan peso (indexed units)", "UYI", 940, 0);
            Debug.Assert(_currenciesPerCountry[Country.UY].Count >= 1, $"{Country.UY} Number of currencies is wrong.");
        }
    }
}
