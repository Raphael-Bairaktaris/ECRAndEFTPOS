using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Requests used for accessing a token
    /// </summary>
    public class AccessTokenRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The username
        /// </summary>
        /// <example>test_username</example>
        [JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// The password
        /// </summary>
        /// <example>test_password</example>
        [JsonProperty("password")]
        public string? Password { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public AccessTokenRequestModel() : base()
        {

        }

        #endregion
    }
}
