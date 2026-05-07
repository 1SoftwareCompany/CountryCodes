using System.Diagnostics;

namespace One.Iso3166.Iso4217;

public partial struct Currency
{
    /// <summary>
    /// ISO 4217:AED is the entry for the United Arab Emirates dirham in ISO 4217, the standard published by the International Organization for Standardization (ISO),
    /// which defines codes for currencies worldwide.
    /// The United Arab Emirates dirham is the official currency of the United Arab Emirates (AE).
    /// Each dirham is subdivided into 100 fils.
    ///     AED: alphabetic code for the United Arab Emirates dirham
    ///     784: numeric code for the United Arab Emirates dirham
    ///     2:   number of digits after the decimal separator (minor units)
    /// </summary>
    /// <remarks>
    /// https://en.wikipedia.org/wiki/United_Arab_Emirates_dirham
    /// LastUpdated: 2026-05-07
    /// </remarks>
    internal static void ISO_4217_AED()
    {
        Add(Country.AE, "United Arab Emirates dirham", "AED", 784, 2);

        Debug.Assert(_currenciesPerCountry[Country.AE].Count == 1, $"{Country.AE} Number of currencies is wrong.");
    }
}
