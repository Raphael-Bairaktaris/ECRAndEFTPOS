using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Represents an authentication code
    /// </summary>
    public class RedeemAuthenticationCodeResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Type"/> property
        /// </summary>
        private string? mType;

        /// <summary>
        /// The member of the <see cref="Id"/> property
        /// </summary>
        private string? mId;

        #endregion

        #region Public Properties

        /// <summary>
        /// The type of the authorization code. Always set to "webecr"
        /// </summary>
        /// <example>webecr</example>
        [JsonProperty("Type")]
        public string Type
        {
            get => mType ?? string.Empty;
            set => mType = value;
        }

        /// <summary>
        /// The API key that should be used for all subsequent API calls for this user
        /// </summary>
        /// <example>Zg6xxfx_R1eXTOs39BPzqQ</example>
        [JsonProperty("Id")]
        public string Id
        {
            get => mId ?? string.Empty;
            set => mId = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RedeemAuthenticationCodeResponseModel() : base()
        {

        }

        #endregion
    }
}
