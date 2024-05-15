using System.Collections.Generic;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// A <see cref="BaseEnumToStringJsonConverter{T}"/> that is used for converting a <see cref="CurrencyCode"/> to <see cref="int"/>
    /// </summary>
    public class CurrencyCodeToIntJsonConverter : BaseEnumToValueJsonConverter<CurrencyCode, int, int>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public CurrencyCodeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<CurrencyCode, int> GetMapper() => ECRAndEFTPOSCommonConstants.CurrencyCodeToIntMapper;

        #endregion
    }
}
