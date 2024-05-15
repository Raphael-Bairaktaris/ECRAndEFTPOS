using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Some calls that typically return many results are paginated. The pagination scheme is common for all paginated responses
    /// </summary>
    /// <typeparam name="T">The type of the results</typeparam>
    public class ResultWrapper<T>
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Next"/> property
        /// </summary>
        private string? mNext;

        /// <summary>
        /// The member of the <see cref="Previous"/> property
        /// </summary>
        private string? mPrevious;

        /// <summary>
        /// The member of the <see cref="Results"/> property
        /// </summary>
        private IEnumerable<T>? mResults;

        #endregion

        #region Public Properties

        /// <summary>
        /// The total results count
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// URL that should be called to retrieve the next page
        /// </summary>
        [JsonProperty("next")]
        public string Next
        {
            get => mNext ?? string.Empty;
            set => mNext = value;
        }

        /// <summary>
        /// URL that should be called to retrieve the previous page.
        /// </summary>
        [JsonProperty("previous")]
        public string Previous
        {
            get => mPrevious ?? string.Empty;
            set => mPrevious = value;
        }

        /// <summary>
        /// The lists that contains the actual results
        /// </summary>
        [JsonProperty("results")]
        public IEnumerable<T> Results
        {
            get => mResults ?? Enumerable.Empty<T>();
            set => mResults = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ResultWrapper() : base()
        {

        }

        #endregion
    }
}
