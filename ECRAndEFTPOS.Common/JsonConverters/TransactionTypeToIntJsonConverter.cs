using System.Collections.Generic;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// A <see cref="BaseEnumToStringJsonConverter{T}"/> that is used to convert a <see cref="TransactionType"/> to <see cref="string"/>
    /// </summary>
    public class TransactionTypeToIntJsonConverter : BaseEnumToIntJsonConverter<TransactionType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransactionTypeToIntJsonConverter() : base()
        {

        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override IReadOnlyDictionary<TransactionType, int> GetMapper() => ECRAndEFTPOSCommonConstants.TransactionTypeToIntMapper;

        #endregion

    }
}
