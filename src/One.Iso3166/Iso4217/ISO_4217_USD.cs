using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_USD()
    {
        Add(Country.AS, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.AS].Count >= 1, $"{Country.AS} Number of currencies is wrong.");

        Add(Country.BQ, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.BQ].Count >= 1, $"{Country.BQ} Number of currencies is wrong.");

        Add(Country.EC, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.EC].Count >= 1, $"{Country.EC} Number of currencies is wrong.");

        Add(Country.FM, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.FM].Count >= 1, $"{Country.FM} Number of currencies is wrong.");

        Add(Country.GU, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.GU].Count >= 1, $"{Country.GU} Number of currencies is wrong.");

        Add(Country.MH, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.MH].Count >= 1, $"{Country.MH} Number of currencies is wrong.");

        Add(Country.MP, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.MP].Count >= 1, $"{Country.MP} Number of currencies is wrong.");

        Add(Country.PA, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.PA].Count >= 2, $"{Country.PA} Number of currencies is wrong.");

        Add(Country.PR, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.PR].Count >= 1, $"{Country.PR} Number of currencies is wrong.");

        Add(Country.PW, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.PW].Count >= 1, $"{Country.PW} Number of currencies is wrong.");

        Add(Country.SV, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.SV].Count >= 2, $"{Country.SV} Number of currencies is wrong.");

        Add(Country.TC, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.TC].Count >= 1, $"{Country.TC} Number of currencies is wrong.");

        Add(Country.TL, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.TL].Count >= 1, $"{Country.TL} Number of currencies is wrong.");

        Add(Country.UM, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.UM].Count >= 1, $"{Country.UM} Number of currencies is wrong.");

        Add(Country.US, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.US].Count >= 1, $"{Country.US} Number of currencies is wrong.");

        Add(Country.VG, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.VG].Count >= 1, $"{Country.VG} Number of currencies is wrong.");

        Add(Country.VI, "United States dollar", "USD", 840, 2);
        Debug.Assert(_currenciesPerCountry[Country.VI].Count >= 1, $"{Country.VI} Number of currencies is wrong.");
    }
}
