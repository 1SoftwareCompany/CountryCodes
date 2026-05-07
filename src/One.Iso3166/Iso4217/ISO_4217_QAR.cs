using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_QAR()
    {
        Add(Country.QA, "Qatari riyal", "QAR", 634, 2);
        Debug.Assert(_currenciesPerCountry[Country.QA].Count >= 1, $"{Country.QA} Number of currencies is wrong.");
    }
}
