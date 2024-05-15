namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Arguments used for retrieving terminals
    /// </summary>
    public class TerminalAPIArgs
    {
        #region Public Properties

        /// <summary>
        /// The limit
        /// </summary>
        public uint Limit { get; set; }

        /// <summary>
        /// The offset
        /// </summary>
        public uint Offset { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TerminalAPIArgs() : base()
        {

        }

        #endregion
    }
}
