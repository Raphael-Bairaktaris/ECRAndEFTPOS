using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Represents a terminal
    /// </summary>
    public class TerminalResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="TerminalId"/> property
        /// </summary>
        private string? mTerminalId;

        /// <summary>
        /// The member of the <see cref="FriendlyName"/> property
        /// </summary>
        private string? mFriendlyName;

        /// <summary>
        /// The member of the <see cref="Merchant"/> property
        /// </summary>
        private string? mMerchant;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of the terminal for the POS backnend
        /// </summary>
        /// <example>358046</example>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The terminal identifier
        /// </summary>
        /// <example>64999964</example>
        [JsonProperty("TerminalID")]
        public string TerminalId
        {
            get => mTerminalId ?? string.Empty;
            set => mTerminalId = value;
        }

        /// <summary>
        /// Friendly name that can be set for quick reference of a POS
        /// </summary>
        /// <example>Test softPOS</example>
        [JsonProperty("FriendlyName")]
        public string FriendlyName
        {
            get => mFriendlyName ?? string.Empty;
            set => mFriendlyName = value;
        }

        /// <summary>
        /// The terminal type of the POS
        /// </summary>
        /// <example>100</example>
        [JsonProperty("TerminalType")]
        public int TerminalType { get; set; }

        /// <summary>
        /// Reference to the unique identifier of the acquirer of the POS
        /// </summary>
        /// <example>11719</example>
        [JsonProperty("Merchant")]
        public string Merchant
        {
            get => mMerchant ?? string.Empty;
            set => mMerchant = value;
        }

        /// <summary>
        /// Reference to the unique identifier of the acquirer of the POS
        /// </summary>
        /// <example>11</example>
        [JsonProperty("Acquirer")]
        public int Acquirer { get; set; }

        /// <summary>
        /// Indicates whether the terminal is currently locked and assigned to a specific mobile device
        /// </summary>
        [JsonProperty("Locked")]
        public bool IsLocked { get; set; }

        /// <summary>
        /// The current batch number of the POS
        /// </summary>
        /// <example>1</example>
        [JsonProperty("CurrentBatchNumber")]
        public int CurrentBatchNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TerminalResponseModel() : base()
        {

        }

        #endregion
    }
}
