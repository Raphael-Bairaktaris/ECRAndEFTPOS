using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Represents an access token
    /// </summary>
    public class AccessTokenResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Access"/> property
        /// </summary>
        private string? mAccess;

        /// <summary>
        /// The member of the <see cref="Refresh"/> property
        /// </summary>
        private string? mRefresh;

        #endregion

        #region Public Properties

        /// <summary>
        /// The access token in JWT form
        /// </summary>
        [JsonProperty("access")]
        public string Access
        {
            get => mAccess ?? string.Empty;
            set => mAccess = value;
        }

        /// <summary>
        /// The refresh token in JWT form
        /// </summary>
        [JsonProperty("refresh")]
        public string Refresh
        {
            get => mRefresh ?? string.Empty;
            set => mRefresh = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AccessTokenResponseModel() : base()
        {

        }

        #endregion
    }
}
