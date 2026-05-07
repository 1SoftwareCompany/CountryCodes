using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_CLF()
    {
        Add(Country.CL, "Unidad de Fomento (funds code)", "CLF", 990, 4);
        Debug.Assert(_currenciesPerCountry[Country.CL].Count >= 2, $"{Country.CL} Number of currencies is wrong.");
    }
}
