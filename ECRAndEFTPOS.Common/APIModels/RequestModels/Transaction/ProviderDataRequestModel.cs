using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// The provider data is an object that contains the provider signature and the information needed to validate the signature as defined by the relevant Greek law.
    /// </summary>
    public class ProviderDataRequestModel
    {
        #region Public Properties

        /// <summary>
        ///  The name of the electronic invoicing provider. It is required for public key lookup.
        ///  Required when a provider signature validation process is used.
        /// </summary>
        /// <example>TestProvider</example>
        [JsonRequired]
        [JsonProperty("ProviderName")]
        public string? ProviderName { get; set; }

        /// <summary>
        ///  The electronic invoicing provider signature. Required when a provider signature validation process is used.
        /// </summary>
        /// <example>12345</example>
        [JsonRequired]
        [JsonProperty("Signature")]
        public string? Signature { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ProviderDataRequestModel() : base()
        {

        }

        #endregion
    }
}
