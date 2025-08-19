﻿using System.Diagnostics;

namespace One.Iso3166
{
    public partial struct Subdivision
    {
        /// <summary>
        /// ISO 3166-2:SX is the entry for Sint Maarten in ISO 3166-2, part of the ISO 3166 standard published by the International Organization for Standardization (ISO),
        /// which defines codes for the names of the principal subdivisions (e.g., provinces or states) of all countries coded in ISO 3166-1.
        /// Currently no ISO 3166-2 codes are defined in the entry for Sint Maarten.The country has no defined subdivisions.
        /// Sint Maarten, a constituent country of the Kingdom of the Netherlands, is officially assigned the ISO 3166-1 alpha-2 code SX. Moreover,
        /// it is also assigned the ISO 3166-2 code NL-SX under the entry for the Netherlands.
        /// </summary>
        /// <remarks>
        /// https://en.wikipedia.org/wiki/ISO_3166-2:SX
        /// LastUpdated: 2023-03-26
        /// </remarks>
        internal static void ISO_3166_2_SX()
        {
            Debug.Assert(_subdivisionsPerCountry.ContainsKey(Country.SX) == false, $"{Country.SX} Number of subdivisions is wrong.");
        }
    }
}
