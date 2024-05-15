namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Provides enumeration over the transaction types
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// Sale
        /// </summary>
        Sale = 0,

        /// <summary>
        /// Refund
        /// </summary>
        Refund = 1,

        /// <summary>
        /// Pre-authorisation
        /// </summary>
        PreAuthorisation = 2,

        /// <summary>
        /// Pre-authorisation completion
        /// </summary>
        PreAutorisationCompletion = 3,

        /// <summary>
        /// Cash advance
        /// </summary>
        CashAdvance = 5,

        /// <summary>
        /// Card payment
        /// </summary>
        CardPayment = 6,

        /// <summary>
        /// Bill payment
        /// </summary>
        BillPayment = 7,

        /// <summary>
        /// Other payment
        /// </summary>
        OtherPayment = 8,

        /// <summary>
        /// Pre payment
        /// </summary>
        PrePayment = 9
    }
}
