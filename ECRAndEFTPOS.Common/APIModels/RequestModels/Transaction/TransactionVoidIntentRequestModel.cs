using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Requests used for a creating a new transaction void intent
    /// </summary>
    public class TransactionVoidIntentRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The unique identifier of the original intent
        /// </summary>
        [JsonProperty("OriginalIntentId")]
        public int? OriginalIntentId { get; set; }

        /// <summary>
        /// The unique identifier of the transaction to be voided
        /// </summary>
        [JsonProperty("OriginalTxnId")]
        public int? OriginalTransactionId { get; set; }

        /// <summary>
        /// If provided and supported by the acquirer, a transaction receipt will be sent to this email address
        /// </summary>
        [JsonProperty("CustomerEmail")]
        public string? CustomerEmail { get; set; }

        /// <summary>
        /// If provided and supported by the acquirer, a transaction receipt will be sent to this phone number
        /// </summary>
        [JsonProperty("CustomerPhone")]
        public string? CustomerPhone { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransactionVoidIntentRequestModel() : base()
        {

        }

        #endregion
    }
}
