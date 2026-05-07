using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_NZD()
    {
        Add(Country.CK, "New Zealand dollar", "NZD", 554, 2);
        Debug.Assert(_currenciesPerCountry[Country.CK].Count >= 1, $"{Country.CK} Number of currencies is wrong.");

        Add(Country.NU, "New Zealand dollar", "NZD", 554, 2);
        Debug.Assert(_currenciesPerCountry[Country.NU].Count >= 1, $"{Country.NU} Number of currencies is wrong.");

        Add(Country.NZ, "New Zealand dollar", "NZD", 554, 2);
        Debug.Assert(_currenciesPerCountry[Country.NZ].Count >= 1, $"{Country.NZ} Number of currencies is wrong.");

        Add(Country.PN, "New Zealand dollar", "NZD", 554, 2);
        Debug.Assert(_currenciesPerCountry[Country.PN].Count >= 1, $"{Country.PN} Number of currencies is wrong.");

        Add(Country.TK, "New Zealand dollar", "NZD", 554, 2);
        Debug.Assert(_currenciesPerCountry[Country.TK].Count >= 1, $"{Country.TK} Number of currencies is wrong.");
    }
}
