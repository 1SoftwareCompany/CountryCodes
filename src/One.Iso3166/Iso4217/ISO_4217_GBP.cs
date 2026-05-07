using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_GBP()
    {
        Add(Country.GB, "Pound sterling", "GBP", 826, 2);
        Debug.Assert(_currenciesPerCountry[Country.GB].Count >= 1, $"{Country.GB} Number of currencies is wrong.");

        Add(Country.GG, "Pound sterling", "GBP", 826, 2);
        Debug.Assert(_currenciesPerCountry[Country.GG].Count >= 1, $"{Country.GG} Number of currencies is wrong.");

        Add(Country.IM, "Pound sterling", "GBP", 826, 2);
        Debug.Assert(_currenciesPerCountry[Country.IM].Count >= 1, $"{Country.IM} Number of currencies is wrong.");

        Add(Country.JE, "Pound sterling", "GBP", 826, 2);
        Debug.Assert(_currenciesPerCountry[Country.JE].Count >= 1, $"{Country.JE} Number of currencies is wrong.");

        Add(Country.SH, "Pound sterling", "GBP", 826, 2);
        Debug.Assert(_currenciesPerCountry[Country.SH].Count >= 1, $"{Country.SH} Number of currencies is wrong.");
    }
}
