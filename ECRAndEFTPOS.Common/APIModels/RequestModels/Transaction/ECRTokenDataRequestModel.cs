using Newtonsoft.Json;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Requests used for the provider
    /// </summary>
    public class ECRTokenDataRequestModel : BaseProviderDataRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The Identification code of the ECR that will generate the EcrToken field.
        /// Used to lookup the appropriate MAC key for validation.Required when an ECR token based validation process is used.
        /// </summary>
        /// <example>ΧΧΧ99000000</example>
        [JsonProperty("EcrId")]
        public string? EcrId { get; set; }

        /// <summary>
        /// The session key used to generate the MAC, encrypted under the master key of the ECR.
        /// Required when an ECR token based validation process is used.
        /// </summary>
        /// <example>1EB73996881AFCA537ACD78B05EB17AD</example>
        [JsonProperty("SessionKey")]
        public string? SessionKey { get; set; }

        /// <summary>
        /// The ECR token (MAC). Required when an ECR token based validation process is used.
        /// </summary>
        /// <example>D182ECE1206169E6</example>
        [JsonProperty("EcrToken")]
        public string? EcrToken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ECRTokenDataRequestModel() : base()
        {

        }

        #endregion
    }
}