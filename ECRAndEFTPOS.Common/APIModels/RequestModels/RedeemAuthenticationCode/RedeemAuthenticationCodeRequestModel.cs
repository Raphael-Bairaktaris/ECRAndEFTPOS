using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Requests used for redeeming an authentication code
    /// </summary>
    public class RedeemAuthenticationCodeRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The type of the authorization code. Always set to "webecr"
        /// </summary>
        /// <example>webecr</example>
        [JsonProperty("Type")]
        public string? Type { get; set; }

        /// <summary>
        /// The authorization code as shown by the POS and entered by the user
        /// </summary>
        /// <example>8413239096</example>
        [JsonProperty("Code")]
        public string? Code { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RedeemAuthenticationCodeRequestModel() : base()
        {

        }

        #endregion
    }
}
