using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_PYG()
    {
        Add(Country.PY, "Paraguayan guaraní", "PYG", 600, 0);
        Debug.Assert(_currenciesPerCountry[Country.PY].Count >= 1, $"{Country.PY} Number of currencies is wrong.");
    }
}
