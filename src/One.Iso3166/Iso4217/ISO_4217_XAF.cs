using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_XAF()
    {
        Add(Country.CF, "Central African CFA franc", "XAF", 950, 0);
        Debug.Assert(_currenciesPerCountry[Country.CF].Count >= 1, $"{Country.CF} Number of currencies is wrong.");

        Add(Country.CG, "Central African CFA franc", "XAF", 950, 0);
        Debug.Assert(_currenciesPerCountry[Country.CG].Count >= 1, $"{Country.CG} Number of currencies is wrong.");

        Add(Country.CM, "Central African CFA franc", "XAF", 950, 0);
        Debug.Assert(_currenciesPerCountry[Country.CM].Count >= 1, $"{Country.CM} Number of currencies is wrong.");

        Add(Country.GA, "Central African CFA franc", "XAF", 950, 0);
        Debug.Assert(_currenciesPerCountry[Country.GA].Count >= 1, $"{Country.GA} Number of currencies is wrong.");

        Add(Country.GQ, "Central African CFA franc", "XAF", 950, 0);
        Debug.Assert(_currenciesPerCountry[Country.GQ].Count >= 1, $"{Country.GQ} Number of currencies is wrong.");

        Add(Country.TD, "Central African CFA franc", "XAF", 950, 0);
        Debug.Assert(_currenciesPerCountry[Country.TD].Count >= 1, $"{Country.TD} Number of currencies is wrong.");
    }
}
