using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_XPF()
    {
        Add(Country.NC, "CFP franc", "XPF", 953, 0);
        Debug.Assert(_currenciesPerCountry[Country.NC].Count >= 1, $"{Country.NC} Number of currencies is wrong.");

        Add(Country.PF, "CFP franc", "XPF", 953, 0);
        Debug.Assert(_currenciesPerCountry[Country.PF].Count >= 1, $"{Country.PF} Number of currencies is wrong.");

        Add(Country.WF, "CFP franc", "XPF", 953, 0);
        Debug.Assert(_currenciesPerCountry[Country.WF].Count >= 1, $"{Country.WF} Number of currencies is wrong.");
    }
}
