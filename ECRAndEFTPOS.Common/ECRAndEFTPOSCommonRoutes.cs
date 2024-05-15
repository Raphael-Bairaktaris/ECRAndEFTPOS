namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// The API routes for the ECR and EFT POS common
    /// </summary>
    public class ECRAndEFTPOSCommonRoutes
    {
        /// <summary>
        /// The production base route
        /// </summary>
        public const string ProductionRoute = "https://www.mreceipts.com/api";

        /// <summary>
        /// The test/staging route
        /// </summary>
        public const string TestRoute = "https://uat.mreceipts.com/api";

        /// <summary>
        /// The access token route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetAccessTokenRoute(string baseRoute) => $"{baseRoute}/token/";

        /// <summary>
        /// The refresh access token route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetRefreshAccessTokenRoute(string baseRoute) => $"{baseRoute}/token/refresh";

        /// <summary>
        /// The redeem authentication code route
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetAuthenticationCodeRoute(string baseRoute) => $"{baseRoute}/v2/authorization/redeem/";

        /// <summary>
        /// The endpoint is used to retrieve a list of all the terminals that are available to the user.
        /// It can be used as a first step to search for a specific terminal by its name, merchant or type and retrieve its terminalId for further processing
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetTerminalListRoute(string baseRoute) => $"{baseRoute}/v2/terminal/";

        /// <summary>
        /// The endpoint is used to start a new transaction by creating an intent.
        /// </summary>
        /// <param name="terminalId">The terminal id</param>
        /// <param name="baseRoute">The base route</param>
        /// <returns></returns>
        public static string GetNewTransactionIntentRoute(string baseRoute, int terminalId) => $"{baseRoute}/v2/terminal/{terminalId}/txninit/";

        /// <summary>
        /// The following endpoint is used to start a new intent to void a transaction. The caller needs to reference the transaction 
        /// that needs to be voided and has the ability to either reference it via the original transaction intent,or the transaction terminalId.
        /// Both values can be obtained either by the response of the original successful intent, or by querying the intent or transaction endpoints.
        /// </summary>
        /// <param name="terminalId">The terminal id</param>
        /// <param name="baseRoute">The base route</param>
        /// <returns></returns>
        public static string GetTransactionVoidIntentRoute(string baseRoute, int terminalId) => $"{baseRoute}/v2/terminal/{terminalId}/txnvoid/";

        /// <summary>
        /// The endpoint is used to list all transaction intents that have been created and accessible to the user. 
        /// It should be used if the "start transaction intent" call has timed out or was async in order to resolve the final status of a specific intent
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        public static string GetTransactionIntentListRoute(string baseRoute) => $"{baseRoute}/v2/transactionintent/";

        /// <summary>
        /// The endpoint is used to list all transaction intents that have been created and accessible to the user. 
        /// It should be used if the "start transaction intent" call has timed out or was async in order to resolve the final status of a specific intent
        /// </summary>
        /// <param name="baseRoute">The base route</param>
        /// <returns></returns>
        public static string GetTransactionListRoute(string baseRoute) => $"{baseRoute}/v2/transaction/";
    }
}
