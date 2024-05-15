using System.Collections.Generic;
using System.Collections.Immutable;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Constants related to the ECRAndEFTPOSCommonConstants clients
    /// </summary>
    public static class ECRAndEFTPOSCommonConstants
    {
        /// <summary>
        /// Maps the <see cref="TransactionType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<TransactionType, int> TransactionTypeToIntMapper { get; } = new Dictionary<TransactionType, int>()
        {
            { TransactionType.Sale, 0 },
            { TransactionType.Refund, 1 },
            { TransactionType.PreAuthorisation, 2 },
            { TransactionType.CashAdvance, 5 },
            { TransactionType.CardPayment, 6 },
            { TransactionType.BillPayment, 7 },
            { TransactionType.OtherPayment, 8 },
            { TransactionType.PrePayment, 9 },
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="CurrencyCode"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<CurrencyCode, int> CurrencyCodeToIntMapper { get; } = new Dictionary<CurrencyCode, int>()
        {
            { CurrencyCode.ALL, 8 },
            { CurrencyCode.DZD, 12 },
            { CurrencyCode.ARS, 32 },
            { CurrencyCode.AUD, 36 },
            { CurrencyCode.BSD, 44 },
            { CurrencyCode.AMD, 51 },
            { CurrencyCode.BBD, 52 },
            //{ CurrencyCode.FOK, 53 },
            { CurrencyCode.BMD, 60 },
            { CurrencyCode.BTN, 64 },
            { CurrencyCode.BOB, 68 },
            { CurrencyCode.BWP, 72 },
            { CurrencyCode.BZD, 84 },
            { CurrencyCode.SBD, 90 },
            { CurrencyCode.BND, 96 },
            { CurrencyCode.MMK, 104 },
            { CurrencyCode.KHR, 116 },
            { CurrencyCode.CAD, 124 },
            { CurrencyCode.CVE, 132 },
            { CurrencyCode.KYD, 136 },
            { CurrencyCode.LKR, 144 },
            { CurrencyCode.CNY, 156 },
            { CurrencyCode.COP, 170 },
            { CurrencyCode.KMF, 174 },
            { CurrencyCode.CRC, 188 },
            { CurrencyCode.HRK, 191 },
            { CurrencyCode.CUP, 192 },
            { CurrencyCode.CZK, 203 },
            { CurrencyCode.DKK, 208 },
            { CurrencyCode.DOP, 214 },
            //{ CurrencyCode.SVC, 222 },
            { CurrencyCode.ETB, 230 },
            { CurrencyCode.ERN, 232 },
            { CurrencyCode.FKP, 238 },
            { CurrencyCode.FJD, 242 },
            { CurrencyCode.DJF, 262 },
            { CurrencyCode.GMD, 270 },
            { CurrencyCode.GIP, 292 },
            //{ CurrencyCode.KID, 296 },
            { CurrencyCode.GTQ, 320 },
            { CurrencyCode.GNF, 324 },
            { CurrencyCode.GYD, 328 },
            { CurrencyCode.HTG, 332 },
            { CurrencyCode.HNL, 340 },
            { CurrencyCode.HKD, 344 },
            { CurrencyCode.HUF, 348 },
            { CurrencyCode.ISK, 352 },
            { CurrencyCode.INR, 356 },
            { CurrencyCode.IDR, 360 },
            { CurrencyCode.IRR, 364 },
            { CurrencyCode.IQD, 368 },
            { CurrencyCode.ILS, 376 },
            { CurrencyCode.JMD, 388 },
            { CurrencyCode.JPY, 392 },
            { CurrencyCode.KZT, 398 },
            { CurrencyCode.JOD, 400 },
            { CurrencyCode.KES, 404 },
            { CurrencyCode.KRW, 410 },
            { CurrencyCode.KWD, 414 },
            { CurrencyCode.KGS, 417 },
            { CurrencyCode.LAK, 418 },
            { CurrencyCode.LBP, 422 },
            { CurrencyCode.LSL, 426 },
            { CurrencyCode.LRD, 430 },
            { CurrencyCode.LYD, 434 },
            { CurrencyCode.MOP, 446 },
            { CurrencyCode.MWK, 454 },
            { CurrencyCode.MYR, 458 },
            { CurrencyCode.MVR, 462 },
            { CurrencyCode.MUR, 480 },
            { CurrencyCode.MXN, 484 },
            { CurrencyCode.MNT, 496 },
            { CurrencyCode.MDL, 498 },
            { CurrencyCode.MAD, 504 },
            { CurrencyCode.OMR, 512 },
            { CurrencyCode.NAD, 516 },
            { CurrencyCode.NPR, 524 },
            { CurrencyCode.ANG, 532 },
            { CurrencyCode.AWG, 533 },
            { CurrencyCode.VUV, 548 },
            { CurrencyCode.NZD, 554 },
            { CurrencyCode.NIO, 558 },
            { CurrencyCode.NGN, 566 },
            { CurrencyCode.NOK, 578 },
            { CurrencyCode.PKR, 586 },
            { CurrencyCode.PAB, 590 },
            { CurrencyCode.PGK, 598 },
            { CurrencyCode.PYG, 600 },
            { CurrencyCode.PEN, 604 },
            { CurrencyCode.PHP, 608 },
            { CurrencyCode.QAR, 634 },
            { CurrencyCode.RUB, 643 },
            { CurrencyCode.RWF, 646 },
            { CurrencyCode.SHP, 654 },
            { CurrencyCode.SAR, 682 },
            { CurrencyCode.SCR, 690 },
            { CurrencyCode.SLL, 694 },
            { CurrencyCode.SGD, 702 },
            { CurrencyCode.VND, 704 },
            { CurrencyCode.SOS, 706 },
            { CurrencyCode.ZAR, 710 },
            { CurrencyCode.SSP, 728 },
            { CurrencyCode.SZL, 748 },
            { CurrencyCode.SEK, 752 },
            { CurrencyCode.CHF, 756 },
            { CurrencyCode.SYP, 760 },
            { CurrencyCode.THB, 764 },
            { CurrencyCode.TOP, 776 },
            { CurrencyCode.TTD, 780 },
            { CurrencyCode.AED, 784 },
            { CurrencyCode.TND, 788 },
            //{ CurrencyCode.TVD, 798 },
            { CurrencyCode.UGX, 800 },
            { CurrencyCode.MKD, 807 },
            { CurrencyCode.EGP, 818 },
            { CurrencyCode.GBP, 826 },
            //{ CurrencyCode.GGP, 831 },
            //{ CurrencyCode.JEP, 832 },
            //{ CurrencyCode.IMP, 833 },
            { CurrencyCode.TZS, 834 },
            { CurrencyCode.USD, 840 },
            { CurrencyCode.UYU, 858 },
            { CurrencyCode.UZS, 860 },
            { CurrencyCode.WST, 882 },
            { CurrencyCode.YER, 886 },
            { CurrencyCode.TWD, 901 },
            //{ CurrencyCode.VES, 928 },
            //{ CurrencyCode.MRU, 929 },
            //{ CurrencyCode.STN, 930 },
            { CurrencyCode.CUC, 931 },
            //{ CurrencyCode.ZWL, 932 },
            { CurrencyCode.BYN, 933 },
            { CurrencyCode.TMT, 934 },
            { CurrencyCode.GHS, 936 },
            { CurrencyCode.SDG, 938 },
            { CurrencyCode.RSD, 941 },
            { CurrencyCode.MZN, 943 },
            { CurrencyCode.AZN, 944 },
            { CurrencyCode.RON, 946 },
            { CurrencyCode.TRY, 949 },
            { CurrencyCode.XAF, 950 },
            { CurrencyCode.XCD, 951 },
            { CurrencyCode.XOF, 952 },
            { CurrencyCode.XPF, 953 },
            //{ CurrencyCode.XDR, 960 },
            { CurrencyCode.ZMW, 967 },
            { CurrencyCode.SRD, 968 },
            { CurrencyCode.MGA, 969 },
            { CurrencyCode.AFN, 971 },
            { CurrencyCode.TJS, 972 },
            { CurrencyCode.AOA, 973 },
            { CurrencyCode.CDF, 976 },
            { CurrencyCode.BAM, 977 },
            { CurrencyCode.EUR, 978 },
            { CurrencyCode.UAH, 980 },
            { CurrencyCode.GEL, 981 },
            { CurrencyCode.PLN, 985 },
            { CurrencyCode.BRL, 986 },

        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="IntentResult"/>s to their related <see cref="string"/>s
        /// </summary>
        public static IReadOnlyDictionary<IntentResult, int> IntentResultToIntMapper { get; } = new Dictionary<IntentResult, int>()
        {
            { IntentResult.Approved, 1 },
            { IntentResult.Declined, 2 },
            { IntentResult.Cancelled, 3 },
            { IntentResult.Failed, 4 },
            { IntentResult.Unknown, 5 },
            { IntentResult.Busy, 6 },
            { IntentResult.MaxTransactions, 7 }
        }.ToImmutableDictionary();

        /// <summary>
        /// Maps the <see cref="IntentStatus"/>es to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<IntentStatus, int> IntentStatusToIntMapper { get; } = new Dictionary<IntentStatus, int>()
        {
            { IntentStatus.Pending, 1 },
            { IntentStatus.Sent, 2 },
            { IntentStatus.Completed, 3 }
        }.ToImmutableDictionary();

        /// <summary>
        /// maps the <see cref="ErrorType"/>s to their related <see cref="int"/>s
        /// </summary>
        public static IReadOnlyDictionary<ErrorType, int> ErrorTypeToIntMapper { get; } = new Dictionary<ErrorType, int>()
        {
            { ErrorType.Error, 0 },
            { ErrorType.Warning, 1 },
            { ErrorType.Information, 2 },
            { ErrorType.Hidden, 3 }
        }.ToImmutableDictionary();

    }
}
