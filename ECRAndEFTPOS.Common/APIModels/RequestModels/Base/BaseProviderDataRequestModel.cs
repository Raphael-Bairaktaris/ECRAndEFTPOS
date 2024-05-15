using Newtonsoft.Json;
using System;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// The base for all the provider's data
    /// </summary>
    public class BaseProviderDataRequestModel
    {
        #region Public Properties

        /// <summary>
        /// The UId of the invoice
        /// </summary>
        /// <example>D4F6A5F5C6123658F78369E5191ED5C9D73CB7AC</example>
        [JsonRequired]
        [JsonProperty("UId")]
        public string? UId { get; set; }

        /// <summary>
        /// The mark
        /// </summary>
        [JsonProperty("Mark")]
        public long? Mark { get; set; }

        /// <summary>
        /// The generation timestamp of Provider Signature in ISO-8601 format
        /// Timezone information should be provided otherwise UTC is assumed
        /// </summary>
        /// <example>2023-11-13T14:00+02:00</example>
        [JsonRequired]
        [JsonProperty("SignatureTimestamp")]
        public DateTimeOffset? SignatureTimestamp { get; set; }

        /// <summary>
        /// The price of goods without any VAT applies to it
        /// </summary>
        /// <example>100</example>
        [JsonRequired]
        [JsonProperty("NetAmount")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// The amount of VAT that is applied to the net amount
        /// </summary>
        /// <example>24</example>
        [JsonRequired]
        [JsonProperty("VatAmount")]
        public decimal? NetAmount { get; set; }

        /// <summary>
        /// The total amount of Net amount and Tax amount
        /// </summary>
        /// <example>124</example>
        [JsonRequired]
        [JsonProperty("TotalAmount")]
        public decimal? Amount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseProviderDataRequestModel() : base()
        {

        }

        #endregion
    }
}
