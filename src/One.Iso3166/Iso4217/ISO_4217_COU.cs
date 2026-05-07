using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_COU()
    {
        Add(Country.CO, "Unidad de Valor Real (UVR) (funds code)", "COU", 970, 2);
        Debug.Assert(_currenciesPerCountry[Country.CO].Count >= 2, $"{Country.CO} Number of currencies is wrong.");
    }
}
