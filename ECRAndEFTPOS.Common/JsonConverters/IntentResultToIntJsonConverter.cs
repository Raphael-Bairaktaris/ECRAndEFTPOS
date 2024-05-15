using System.Collections.Generic;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// A <see cref="BaseEnumToIntJsonConverter{T}"/> that is used to convert an <see cref="IntentResult"/> to <see cref="int"/>
    /// </summary>
    public class IntentResultToIntJsonConverter : BaseEnumToIntJsonConverter<IntentResult>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IntentResultToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<IntentResult, int> GetMapper() => ECRAndEFTPOSCommonConstants.IntentResultToIntMapper;

        #endregion
    }
}
