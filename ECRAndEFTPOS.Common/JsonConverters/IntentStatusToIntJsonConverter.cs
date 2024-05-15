using System.Collections.Generic;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// A <see cref="BaseEnumToIntJsonConverter{T}"/> that is used to convert an <see cref="IntentStatus"/> to <see cref="int"/>
    /// </summary>
    public class IntentStatusToIntJsonConverter : BaseEnumToIntJsonConverter<IntentStatus>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public IntentStatusToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<IntentStatus, int> GetMapper() => ECRAndEFTPOSCommonConstants.IntentStatusToIntMapper;

        #endregion
    }
}
