namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Provides enumeration over the intents results
    /// </summary>
    public enum IntentResult
    {
        /// <summary>
        /// The transaction has been completed and approved by the authorization system
        /// </summary>
        Approved = 1,

        /// <summary>
        /// The transaction has been completed and declined by the authorization system
        /// </summary>
        Declined = 2,

        /// <summary>
        /// The transaction has been canceled by the POS user before reaching completion
        /// </summary>
        Cancelled = 3,

        /// <summary>
        /// The transaction has failed to complete
        /// </summary>
        Failed = 4,

        /// <summary>
        ///  The transaction result is unknown. 
        ///  Only possible if the device hasn't responded with results
        /// </summary>
        Unknown = 5,

        /// <summary>
        ///  The transaction has failed because the POS is currently unavailable for transactions (either processing another transaction or under maintenance)
        /// </summary>
        Busy = 6,

        /// <summary>
        ///  The POS device has reached its transaction limit for the specific batch. 
        ///  Batch closing should be performed on the device before continuing transactions
        /// </summary>
        MaxTransactions = 7
    }
}
