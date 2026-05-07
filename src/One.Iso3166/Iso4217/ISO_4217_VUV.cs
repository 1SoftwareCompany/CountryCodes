using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_VUV()
    {
        Add(Country.VU, "Vanuatu vatu", "VUV", 548, 0);
        Debug.Assert(_currenciesPerCountry[Country.VU].Count >= 1, $"{Country.VU} Number of currencies is wrong.");
    }
}
