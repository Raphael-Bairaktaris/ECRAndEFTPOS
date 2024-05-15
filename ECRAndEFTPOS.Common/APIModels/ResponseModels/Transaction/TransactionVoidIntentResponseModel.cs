using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Represents a transaction void intent
    /// </summary>
    public class TransactionVoidIntentResponseModel
    {
        #region Private Members

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
        [JsonProperty("Id")]
        public int Id { get; set; }

        /// <summary>
        /// The intent status
        /// </summary>
        [JsonProperty("Status")]
        [JsonConverter(typeof(IntentStatusToIntJsonConverter))]
        public IntentStatus Status { get; set; }

        /// <summary>
        /// The intent result
        /// </summary>
        [JsonProperty("Result")]
        [JsonConverter(typeof(IntentResultToIntJsonConverter))]
        public IntentResult Result { get; set; }

        /// <summary>
        /// Reference to the terminal which this intent was sent to
        /// </summary>
        [JsonProperty("Terminal")]
        public int Terminal { get; set; }

        /// <summary>
        /// Email that the receipt was/is going to be sent
        /// </summary>
        [JsonProperty("CustomerEmail")]
        public string CustomerEmail
        {
            get => mCustomerEmail ?? string.Empty;
            set => mCustomerEmail = value;
        }

        /// <summary>
        /// Phone that a receipt was/is going to be sent
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
        public TransactionVoidIntentResponseModel() : base()
        {

        }

        #endregion
    }
}
