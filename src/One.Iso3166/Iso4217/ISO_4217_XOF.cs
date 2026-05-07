using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_XOF()
    {
        Add(Country.BF, "West African CFA franc", "XOF", 952, 0);
        Debug.Assert(_currenciesPerCountry[Country.BF].Count >= 1, $"{Country.BF} Number of currencies is wrong.");

        Add(Country.BJ, "West African CFA franc", "XOF", 952, 0);
        Debug.Assert(_currenciesPerCountry[Country.BJ].Count >= 1, $"{Country.BJ} Number of currencies is wrong.");

        Add(Country.CI, "West African CFA franc", "XOF", 952, 0);
        Debug.Assert(_currenciesPerCountry[Country.CI].Count >= 1, $"{Country.CI} Number of currencies is wrong.");

        Add(Country.GW, "West African CFA franc", "XOF", 952, 0);
        Debug.Assert(_currenciesPerCountry[Country.GW].Count >= 1, $"{Country.GW} Number of currencies is wrong.");

        Add(Country.ML, "West African CFA franc", "XOF", 952, 0);
        Debug.Assert(_currenciesPerCountry[Country.ML].Count >= 1, $"{Country.ML} Number of currencies is wrong.");

        Add(Country.NE, "West African CFA franc", "XOF", 952, 0);
        Debug.Assert(_currenciesPerCountry[Country.NE].Count >= 1, $"{Country.NE} Number of currencies is wrong.");

        Add(Country.SN, "West African CFA franc", "XOF", 952, 0);
        Debug.Assert(_currenciesPerCountry[Country.SN].Count >= 1, $"{Country.SN} Number of currencies is wrong.");

        Add(Country.TG, "West African CFA franc", "XOF", 952, 0);
        Debug.Assert(_currenciesPerCountry[Country.TG].Count >= 1, $"{Country.TG} Number of currencies is wrong.");
    }
}
