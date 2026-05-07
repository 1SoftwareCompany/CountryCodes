using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    internal static void ISO_4217_XCD()
    {
        Add(Country.AG, "Eastern Caribbean dollar", "XCD", 951, 2);
        Debug.Assert(_currenciesPerCountry[Country.AG].Count >= 1, $"{Country.AG} Number of currencies is wrong.");

        Add(Country.AI, "Eastern Caribbean dollar", "XCD", 951, 2);
        Debug.Assert(_currenciesPerCountry[Country.AI].Count >= 1, $"{Country.AI} Number of currencies is wrong.");

        Add(Country.DM, "Eastern Caribbean dollar", "XCD", 951, 2);
        Debug.Assert(_currenciesPerCountry[Country.DM].Count >= 1, $"{Country.DM} Number of currencies is wrong.");

        Add(Country.GD, "Eastern Caribbean dollar", "XCD", 951, 2);
        Debug.Assert(_currenciesPerCountry[Country.GD].Count >= 1, $"{Country.GD} Number of currencies is wrong.");

        Add(Country.KN, "Eastern Caribbean dollar", "XCD", 951, 2);
        Debug.Assert(_currenciesPerCountry[Country.KN].Count >= 1, $"{Country.KN} Number of currencies is wrong.");

        Add(Country.LC, "Eastern Caribbean dollar", "XCD", 951, 2);
        Debug.Assert(_currenciesPerCountry[Country.LC].Count >= 1, $"{Country.LC} Number of currencies is wrong.");

        Add(Country.MS, "Eastern Caribbean dollar", "XCD", 951, 2);
        Debug.Assert(_currenciesPerCountry[Country.MS].Count >= 1, $"{Country.MS} Number of currencies is wrong.");

        Add(Country.VC, "Eastern Caribbean dollar", "XCD", 951, 2);
        Debug.Assert(_currenciesPerCountry[Country.VC].Count >= 1, $"{Country.VC} Number of currencies is wrong.");
    }
}
