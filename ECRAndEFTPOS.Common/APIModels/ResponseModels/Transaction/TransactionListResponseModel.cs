namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Represents a collection of transactions
    /// </summary>
    public class TransactionListResponseModel : ResultWrapper<TransactionResponseModel>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransactionListResponseModel() : base()
        {

        }

        #endregion
    }
}