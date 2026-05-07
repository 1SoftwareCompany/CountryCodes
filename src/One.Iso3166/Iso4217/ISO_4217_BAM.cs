using System.Diagnostics;

namespace One.Iso3166.Iso4217
{
    public partial struct Currency
    {
        internal static void ISO_4217_BAM()
        {
            Add(Country.BA, "Bosnia and Herzegovina convertible mark", "BAM", 977, 2);
            Debug.Assert(_currenciesPerCountry[Country.BA].Count >= 1, $"{Country.BA} Number of currencies is wrong.");
        }
    }
}
