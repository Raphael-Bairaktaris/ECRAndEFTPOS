namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Provides enumeration over the intent status
    /// </summary>
    public enum IntentStatus
    {
        /// <summary>
        /// Intent has been registered to the backend and is pending to be sent to the device
        /// </summary>
        Pending = 1,

        /// <summary>
        /// Intent has been registered to the backend and is pending to be sent to the device
        /// </summary>
        Sent = 2,

        /// <summary>
        /// Intent has been successfully completed by the device and has registered the results
        /// </summary>
        Completed = 3
    }
}
