using System.Net;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Represents a set of credentials used by the common ECR-EFT POS providers
    /// </summary>
    public record ECRAndEFTPOSCommonCredentials
    {
        #region Public Properties

        /// <summary>
        /// The username
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// The password
        /// </summary>
        public string Password { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ECRAndEFTPOSCommonCredentials(string username, string password) : base()
        {
            Username = username.NotNullOrEmpty();
            Password = password.NotNullOrEmpty();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates and returns a <see cref="AccessTokenRequestModel"/> from the current <see cref="ECRAndEFTPOSCommonCredentials"/>
        /// </summary>
        /// <returns></returns>
        public AccessTokenRequestModel ToAccessTokenRequestModel()
        {
            return new AccessTokenRequestModel() { Username = Username, Password = Password };
        }

        #endregion
    }
}
