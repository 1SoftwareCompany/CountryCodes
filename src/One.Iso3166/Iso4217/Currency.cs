using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace One.Iso3166.Iso4217;

[Serializable]
[DataContract(Name = "iso-4217")]
public partial struct Currency : IEquatable<Currency>
{
    private static readonly Dictionary<int, CurrencyTableEntry> _allCurrencies = new Dictionary<int, CurrencyTableEntry>();
    private static readonly Dictionary<Country, List<Currency>> _currenciesPerCountry = new Dictionary<Country, List<Currency>>();

    [DataMember(Order = 0)]
    private readonly int _currencyId;

    public readonly int Id => _currencyId;

    static Currency()
    {
        ISO_4217_AED();
        ISO_4217_AFN();
        ISO_4217_ALL();
        ISO_4217_AMD();
        ISO_4217_AOA();
        ISO_4217_ARS();
        ISO_4217_AUD();
        ISO_4217_AWG();
        ISO_4217_AZN();
        ISO_4217_BAM();
        ISO_4217_BBD();
        ISO_4217_BDT();
        ISO_4217_BHD();
        ISO_4217_BIF();
        ISO_4217_BMD();
        ISO_4217_BND();
        ISO_4217_BOB();
        ISO_4217_BOV();
        ISO_4217_BRL();
        ISO_4217_BSD();
        ISO_4217_BTN();
        ISO_4217_BWP();
        ISO_4217_BYN();
        ISO_4217_BZD();
        ISO_4217_CAD();
        ISO_4217_CDF();
        ISO_4217_CHE();
        ISO_4217_CHF();
        ISO_4217_CHW();
        ISO_4217_CLF();
        ISO_4217_CLP();
        ISO_4217_CNY();
        ISO_4217_COP();
        ISO_4217_COU();
        ISO_4217_CRC();
        ISO_4217_CUP();
        ISO_4217_CVE();
        ISO_4217_CZK();
        ISO_4217_DJF();
        ISO_4217_DKK();
        ISO_4217_DOP();
        ISO_4217_DZD();
        ISO_4217_EGP();
        ISO_4217_ERN();
        ISO_4217_ETB();
        ISO_4217_EUR();
        ISO_4217_FJD();
        ISO_4217_FKP();
        ISO_4217_GBP();
        ISO_4217_GEL();
        ISO_4217_GHS();
        ISO_4217_GIP();
        ISO_4217_GMD();
        ISO_4217_GNF();
        ISO_4217_GTQ();
        ISO_4217_GYD();
        ISO_4217_HKD();
        ISO_4217_HNL();
        ISO_4217_HTG();
        ISO_4217_HUF();
        ISO_4217_IDR();
        ISO_4217_ILS();
        ISO_4217_INR();
        ISO_4217_IQD();
        ISO_4217_IRR();
        ISO_4217_ISK();
        ISO_4217_JMD();
        ISO_4217_JOD();
        ISO_4217_JPY();
        ISO_4217_KES();
        ISO_4217_KGS();
        ISO_4217_KHR();
        ISO_4217_KMF();
        ISO_4217_KPW();
        ISO_4217_KRW();
        ISO_4217_KWD();
        ISO_4217_KYD();
        ISO_4217_KZT();
        ISO_4217_LAK();
        ISO_4217_LBP();
        ISO_4217_LKR();
        ISO_4217_LRD();
        ISO_4217_LSL();
        ISO_4217_LYD();
        ISO_4217_MAD();
        ISO_4217_MDL();
        ISO_4217_MGA();
        ISO_4217_MKD();
        ISO_4217_MMK();
        ISO_4217_MNT();
        ISO_4217_MOP();
        ISO_4217_MRU();
        ISO_4217_MUR();
        ISO_4217_MVR();
        ISO_4217_MWK();
        ISO_4217_MXN();
        ISO_4217_MXV();
        ISO_4217_MYR();
        ISO_4217_MZN();
        ISO_4217_NAD();
        ISO_4217_NGN();
        ISO_4217_NIO();
        ISO_4217_NOK();
        ISO_4217_NPR();
        ISO_4217_NZD();
        ISO_4217_OMR();
        ISO_4217_PAB();
        ISO_4217_PEN();
        ISO_4217_PGK();
        ISO_4217_PHP();
        ISO_4217_PKR();
        ISO_4217_PLN();
        ISO_4217_PYG();
        ISO_4217_QAR();
        ISO_4217_RON();
        ISO_4217_RSD();
        ISO_4217_RUB();
        ISO_4217_RWF();
        ISO_4217_SAR();
        ISO_4217_SBD();
        ISO_4217_SCR();
        ISO_4217_SDG();
        ISO_4217_SEK();
        ISO_4217_SGD();
        ISO_4217_SHP();
        ISO_4217_SLE();
        ISO_4217_SOS();
        ISO_4217_SRD();
        ISO_4217_SSP();
        ISO_4217_STN();
        ISO_4217_SVC();
        ISO_4217_SYP();
        ISO_4217_SZL();
        ISO_4217_THB();
        ISO_4217_TJS();
        ISO_4217_TMT();
        ISO_4217_TND();
        ISO_4217_TOP();
        ISO_4217_TRY();
        ISO_4217_TTD();
        ISO_4217_TWD();
        ISO_4217_TZS();
        ISO_4217_UAH();
        ISO_4217_UGX();
        ISO_4217_USD();
        ISO_4217_USN();
        ISO_4217_UYI();
        ISO_4217_UYU();
        ISO_4217_UYW();
        ISO_4217_UZS();
        ISO_4217_VED();
        ISO_4217_VES();
        ISO_4217_VND();
        ISO_4217_VUV();
        ISO_4217_WST();
        ISO_4217_XAF();
        ISO_4217_XCD();
        ISO_4217_XOF();
        ISO_4217_XPF();
        ISO_4217_YER();
        ISO_4217_ZAR();
        ISO_4217_ZMW();
        ISO_4217_ZWG();
    }

    public Currency() { _currencyId = 0; }

    public Currency(string code) : this(HashCodeUtility.GetPersistentHashCode(code)) { }

    internal Currency(int currencyId)
    {
        if (_allCurrencies.ContainsKey(currencyId) == false) throw new ArgumentException("The value isn't valid currency code.", nameof(currencyId));

        _currencyId = currencyId;
    }

    public readonly string Name => GetEntry(_currencyId).Name;

    public readonly string Code => GetEntry(_currencyId).Code;

    public readonly int NumericCode => GetEntry(_currencyId).NumericCode;

    public readonly ushort D => GetEntry(_currencyId).D;

    private static CurrencyTableEntry GetEntry(int currencyId)
    {
        if (_allCurrencies.TryGetValue(currencyId, out CurrencyTableEntry entry) == false)
            entry = CurrencyTableEntry.Default;

        return entry;
    }

    public static void Add(Country country, string name, string code, int numericCode, ushort d)
    {
        CurrencyTableEntry entry = new CurrencyTableEntry(name, code, numericCode, d);

        _allCurrencies.Add(entry.Id, entry);

        AddCurrencyToCountry(country, new Currency(entry.Id));
    }

    private static void AddCurrencyToCountry(Country country, Currency currency)
    {
        if (_currenciesPerCountry.ContainsKey(country) == false)
            _currenciesPerCountry.Add(country, new List<Currency>());

        _currenciesPerCountry[country].Add(currency);
    }

    private static ReadOnlyCollection<Currency> NoCurrencies = new List<Currency>().AsReadOnly();

    internal static ReadOnlyCollection<Currency> GetCountryCurrencies(Country country)
    {
        if (_currenciesPerCountry.ContainsKey(country) == false)
            return NoCurrencies;

        return _currenciesPerCountry[country].AsReadOnly();
    }

    public static implicit operator Currency(string value)
    {
        return new Currency(value);
    }

    public static bool operator ==(Currency left, Currency right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Currency left, Currency right)
    {
        return left.Equals(right) == false;
    }

    public readonly override bool Equals(object obj)
    {
        if (obj is Currency currency)
            return Equals(currency);

        return false;
    }

    public readonly bool Equals(Currency other)
    {
        return _currencyId == other._currencyId;
    }

    public readonly override int GetHashCode()
    {
        unchecked
        {
            return _currencyId ^ 69691;
        }
    }

    public readonly override string ToString() => Code;

    private readonly struct CurrencyTableEntry
    {
        const string CurrencyPattern = @"^[A-Z]{3}$";
        static Regex Validator = new Regex(CurrencyPattern);

        /// <summary>
        /// The internal ID of the currency.
        /// </summary>
        internal readonly int Id = 0;

        /// <summary>
        /// The currency name, e.g. "United States Dollar".
        /// </summary>
        internal readonly string Name = string.Empty;

        /// <summary>
        /// The ISO 4217 code of the currency, e.g. "USD".
        /// </summary>
        internal readonly string Code = string.Empty;

        /// <summary>
        /// Th+e ISO 4217 numeric code of the currency, e.g. 840 for USD.
        /// </summary>
        internal readonly int NumericCode = 0;

        /// <summary>
        /// The number of decimal places used by the currency, e.g. 2 for USD.
        /// </summary>
        internal readonly ushort D = 0;

        internal CurrencyTableEntry(string name, string code, int numericCode, ushort d)
        {
            var match = Validator.Match(code);
            if (match.Success == false)
                throw new ArgumentException($"Invalid currency code: {code}. Must be exactly 3 uppercase letters.");

            Name = name;
            Code = code;
            NumericCode = numericCode;
            D = d;

            Id = HashCodeUtility.GetPersistentHashCode(Code);
        }

        private CurrencyTableEntry(int id)
        {
            Id = id;
            Name = string.Empty;
            Code = string.Empty;
            NumericCode = 0;
            D = 0;
        }

        public static CurrencyTableEntry Default = new CurrencyTableEntry(0);
    }
}
