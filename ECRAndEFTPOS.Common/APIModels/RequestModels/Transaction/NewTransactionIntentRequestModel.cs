using Newtonsoft.Json;
using System;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Requests used for initiating a new transaction
    /// </summary>
    public class NewTransactionIntentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The transaction type
        /// </summary>
        [JsonRequired]
        [JsonProperty("TxnType")]
        [JsonConverter(typeof(TransactionTypeToIntJsonConverter))]
        public TransactionType? TransactionType { get; set; }

        /// <summary>
        /// The transaction amount in integer form
        /// </summary>
        /// <example>1.00eur is 100</example>
        [JsonRequired]
        [JsonProperty("Amount")]
        public int? Amount { get; set; }

        /// <summary>
        /// The tip amount in integer from
        /// </summary>
        /// <example>1.00eur is 100</example>
        [JsonProperty("TipAmount")]
        public int? TipAmount { get; set; }

        /// <summary>
        /// The cashback amount in integer from
        /// </summary>
        /// <example>1.00eur is 100</example>
        [JsonProperty("CashbackAmount")]
        public int? CashbackAmount { get; set; }

        /// <summary>
        /// The ISO 4217 numerical currency code.
        /// </summary>
        /// <example>978 for EUR</example>
        [JsonRequired]
        [JsonProperty("CurrencyCode")]
        [JsonConverter(typeof(CurrencyCodeToIntJsonConverter))]
        public CurrencyCode? CurrencyCode { get; set; }

        /// <summary>
        /// The number of instalments
        /// </summary>
        /// <example>0</example>
        [JsonProperty("Instalments")]
        public int? Instalments { get; set; }

        /// <summary>
        /// Indicates whether the transaction is eligible to tax free regulation
        /// </summary>
        [JsonProperty("IsTaxFree")]
        public bool? IsTaxFree { get; set; }

        /// <summary>
        /// Indicates whether the transaction should be preloaded to the POS device for asynchronous execution
        /// Used for cases such as restaurants, deliveries, coffee shops etc
        /// </summary>
        [JsonProperty("PreloadTransaction")]
        public bool? ShouldPreloadTransaction { get; set; }

        /// <summary>
        ///  The expiration of a transaction that is preloaded to a
        ///  POS, in minutes.The field is mandatory if PreloadTransaction is true
        /// </summary>
        [JsonProperty("PreloadExpiration")]
        public TimeSpan? PreloadExpiration { get; set; }

        /// <summary>
        /// The payee collects the transaction fund on behalf of another entity
        /// Example: courier payment on delivery, food delivery platforms
        /// </summary>
        [JsonProperty("OnBehalfCollection")]
        public bool? IsOnBehalfCollection { get; set; }

        /// <summary>
        /// A called defined reference which can be used to reference the intent and eventually the transaction
        /// </summary>
        /// <example>"b7775c92-0be9-4005-9450-e45769e593e2</example>
        [JsonRequired]
        [JsonProperty("CustomerReference")]
        public string? CustomerReference { get; set; }

        /// <summary>
        /// If provided and supported by the acquirer a transaction receipt will be sent to the email address
        /// </summary>
        [JsonProperty("CustomerEmail")]
        public string? CustomerEmail { get; set; }

        /// <summary>
        /// If provided and supported by the acquirer a transaction receipt will be sent to the phone
        /// </summary>
        [JsonProperty("CustomerPhone")]
        public string? CustomerPhone { get; set; }

        /// <summary>
        /// Optional for refund transaction where it references the original debit transaction
        /// Required for pre-authorization completion where it references the original
        /// pre-authorization transaction request
        /// </summary>
        [JsonProperty("InitialTransaction")]
        public int? InitialTransaction { get; set; }

        /// <summary>
        /// A data object representing the relevant data required by Greek law to accompany 
        /// a provider signature based transaction request
        /// </summary>
        [JsonProperty("ProviderData")]
        public ProviderDataRequestModel? ProviderData { get; set; }

        /// <summary>
        ///  A data object representing the relevant data required by Greek law to accompany 
        /// an ECR token MAC based transaction request.
        /// </summary>
        [JsonProperty("EcrTokenData")]
        public ECRTokenDataRequestModel? ECRTokenData { get; set; }

        /// <summary>
        /// If timeout is 0 or not present, the transaction will be initiated asynchronously. If present
        /// The service will wait up to "Timeout" seconds before returning to the caller
        /// Max timeout is 180s.
        /// </summary>
        [JsonProperty("Timeout")]
        public TimeSpan? Timeout { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public NewTransactionIntentRequestModel() : base()
        {

        }

        #endregion
    }
}
