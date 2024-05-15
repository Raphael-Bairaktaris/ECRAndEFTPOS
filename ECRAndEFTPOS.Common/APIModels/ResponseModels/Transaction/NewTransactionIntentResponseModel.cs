using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Represents a new transaction intent
    /// </summary>
    public class NewTransactionIntentResponseModel : BaseTransactionIntentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TransactionId"/> property
        /// </summary>
        private string? mTransactionId;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique transaction id required in the Greek market as mandated and defined by law
        /// </summary>
        /// <example>075121702285176315144</example>
        [JsonProperty("TransactionId")]
        public string TransactionId
        {
            get => mTransactionId ?? string.Empty;
            set => mTransactionId = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public NewTransactionIntentResponseModel() : base()
        {

        }

        #endregion
    }
}
