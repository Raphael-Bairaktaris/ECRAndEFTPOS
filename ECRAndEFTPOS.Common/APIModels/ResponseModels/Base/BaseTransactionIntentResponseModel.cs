using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// The base for all the transaction intents 
    /// </summary>
    public class BaseTransactionIntentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="CustomerReference"/> property
        /// </summary>
        private string? mCustomerReference;

        /// <summary>
        /// The member of the <see cref="CustomerEmail"/> property
        /// </summary>
        private string? mCustomerEmail;

        /// <summary>
        /// The member of the <see cref="CustomerPhone"/> property
        /// </summary>
        private string? mCustomerPhone;

        /// <summary>
        /// The member of the <see cref="Transaction"/> property
        /// </summary>
        private TransactionListResponseModel? mTransaction;

        /// <summary>
        /// The member of the <see cref="InitialTransaction"/> property
        /// </summary>
        private TransactionListResponseModel? mInitialTransaction;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of the intent for the POS backend
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The intent status
        /// </summary>
        [JsonProperty("Status")]
        [JsonConverter(typeof(IntentResultToIntJsonConverter))]
        public IntentStatus Status { get; set; }

        /// <summary>
        /// The intent result
        /// </summary>
        [JsonProperty("Result")]
        [JsonConverter(typeof(IntentResultToIntJsonConverter))]
        public IntentResult Result { get; set; }

        /// <summary>
        /// The transaction type
        /// </summary>
        [JsonProperty("TxnType")]
        [JsonConverter(typeof(TransactionTypeToIntJsonConverter))]
        public TransactionType TransactionType { get; set; }

        /// <summary>
        /// The transaction amount in integer form
        /// </summary>
        /// <example>1.00eur is 100</example>
        [JsonProperty("Amount")]
        public int Amount { get; set; }

        /// <summary>
        /// The tip amount integer form
        /// </summary>
        /// <example>1.00eur is 100</example>
        [JsonProperty("TipAmount")]
        public int TipAmount { get; set; }

        /// <summary>
        /// The ISO 4217 numerical currency code
        /// </summary>
        /// <example>978 for EUR</example>
        [JsonProperty("CurrencyCode")]
        [JsonConverter(typeof(CurrencyCodeToIntJsonConverter))]
        public CurrencyCode CurrencyCode { get; set; }

        /// <summary>
        /// The number of instalments
        /// </summary>
        /// <example>0</example>
        [JsonProperty("Instalments")]
        public int Instalments { get; set; }

        /// <summary>
        /// The caller defined reference which can be used to reference the intent and eventually the transaction
        /// </summary>
        /// <example>b7775c92-0be9-4005-9450-e45769e593e2</example>
        [JsonProperty("CustomerReference")]
        public string CustomerReference
        {
            get => mCustomerReference ?? string.Empty;
            set => mCustomerReference = value;
        }

        /// <summary>
        /// Reference to the terminal which this intent was sent to
        /// </summary>
        /// <example>358154</example>
        [JsonProperty("Terminal")]
        public int Terminal { get; set; }

        /// <summary>
        /// Email that a receipt was/is going to be sent
        /// </summary>
        [JsonProperty("CustomerEmail")]
        public string CustomerEmail
        {
            get => mCustomerEmail ?? string.Empty;
            set => mCustomerEmail = value;
        }

        /// <summary>
        /// The phone that a receipt was/is going to be sent
        /// </summary>
        [JsonProperty("CustomerPhone")]
        public string CustomerPhone
        {
            get => mCustomerPhone ?? string.Empty;
            set => mCustomerPhone = value;
        }

        /// <summary>
        /// Contains the transaction result details
        /// </summary>
        [JsonProperty("Transaction")]
        public TransactionListResponseModel Transaction
        {
            get => mTransaction ??= new TransactionListResponseModel();
            set => mTransaction = value;
        }

        /// <summary>
        /// Contains the initial transaction details
        /// ONLY applicable if TransactionType = refund or pre auth completion
        /// </summary>
        [JsonProperty("InitialTransaction")]
        public TransactionListResponseModel InitialTransaction
        {
            get => mInitialTransaction ??= new TransactionListResponseModel();
            set => mInitialTransaction = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseTransactionIntentResponseModel() : base()
        {

        }

        #endregion
    }
}
