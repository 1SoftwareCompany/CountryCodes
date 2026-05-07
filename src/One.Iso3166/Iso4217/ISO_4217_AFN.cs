using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    /// <summary>
    /// ISO 4217:AFN is the entry for the Afghan afghani in ISO 4217, the standard published by the International Organization for Standardization (ISO),
    /// which defines codes for currencies worldwide.
    /// The Afghan afghani is the official currency of Afghanistan (AF).
    /// Each afghani is subdivided into 100 pul.
    ///     AFN: alphabetic code for the Afghan afghani
    ///     971: numeric code for the Afghan afghani
    ///     2:   number of digits after the decimal separator (minor units)
    /// </summary>
    /// <remarks>
    /// https://en.wikipedia.org/wiki/Afghan_afghani
    /// LastUpdated: 2026-05-07
    /// </remarks>
    internal static void ISO_4217_AFN()
    {
        Add(Country.AF, "Afghan afghani", "AFN", 971, 2);

        Debug.Assert(_currenciesPerCountry[Country.AF].Count == 1, $"{Country.AF} Number of currencies is wrong.");
    }
}
