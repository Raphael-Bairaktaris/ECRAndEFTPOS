using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Represents a refresh access token
    /// </summary>
    public class RefreshTokenResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Access"/> property
        /// </summary>
        private string? mAccess;

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

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public RefreshTokenResponseModel() : base()
        {

        }

        #endregion
    }
}
