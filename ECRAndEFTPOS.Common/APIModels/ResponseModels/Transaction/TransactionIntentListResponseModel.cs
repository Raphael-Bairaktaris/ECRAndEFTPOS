using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Represents a collection of transaction intents
    /// </summary>
    public class TransactionIntentListResponseModel : ResultWrapper<TransactionIntentResponseModel>
    { 
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransactionIntentListResponseModel() : base()
        {

        }

        #endregion
    }
}
