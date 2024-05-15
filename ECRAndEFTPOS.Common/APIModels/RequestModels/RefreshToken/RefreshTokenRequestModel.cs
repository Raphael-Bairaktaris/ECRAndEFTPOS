using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Requests used for refreshing an access token
    /// </summary>
    public class RefreshTokenRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The previously acquired refresh token
        /// </summary>
        [JsonProperty("refersh")]
        public string? Refresh { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RefreshTokenRequestModel() : base()
        {

        }

        #endregion
    }
}
