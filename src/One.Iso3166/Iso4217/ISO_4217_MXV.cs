using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_MXV()
    {
        Add(Country.MX, "Mexican Unidad de Inversion (UDI)", "MXV", 979, 2);
        Debug.Assert(_currenciesPerCountry[Country.MX].Count >= 2, $"{Country.MX} Number of currencies is wrong.");
    }
}
