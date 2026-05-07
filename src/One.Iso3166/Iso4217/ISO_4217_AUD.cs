using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_AUD()
    {
        Add(Country.AU, "Australian dollar", "AUD", 036, 2);
        Debug.Assert(_currenciesPerCountry[Country.AU].Count >= 1, $"{Country.AU} Number of currencies is wrong.");

        Add(Country.CX, "Australian dollar", "AUD", 036, 2);
        Debug.Assert(_currenciesPerCountry[Country.CX].Count >= 1, $"{Country.CX} Number of currencies is wrong.");

        Add(Country.CC, "Australian dollar", "AUD", 036, 2);
        Debug.Assert(_currenciesPerCountry[Country.CC].Count >= 1, $"{Country.CC} Number of currencies is wrong.");

        Add(Country.HM, "Australian dollar", "AUD", 036, 2);
        Debug.Assert(_currenciesPerCountry[Country.HM].Count >= 1, $"{Country.HM} Number of currencies is wrong.");

        Add(Country.KI, "Australian dollar", "AUD", 036, 2);
        Debug.Assert(_currenciesPerCountry[Country.KI].Count >= 1, $"{Country.KI} Number of currencies is wrong.");

        Add(Country.NF, "Australian dollar", "AUD", 036, 2);
        Debug.Assert(_currenciesPerCountry[Country.NF].Count >= 1, $"{Country.NF} Number of currencies is wrong.");

        Add(Country.NR, "Australian dollar", "AUD", 036, 2);
        Debug.Assert(_currenciesPerCountry[Country.NR].Count >= 1, $"{Country.NR} Number of currencies is wrong.");

        Add(Country.TV, "Australian dollar", "AUD", 036, 2);
        Debug.Assert(_currenciesPerCountry[Country.TV].Count >= 1, $"{Country.TV} Number of currencies is wrong.");
    }
}
