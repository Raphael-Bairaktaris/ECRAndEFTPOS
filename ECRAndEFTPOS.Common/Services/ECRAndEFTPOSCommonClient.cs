using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// An agent that's capable of making requests to the ECR and EFT POS API
    /// </summary>
    public class ECRAndEFTPOSCommonClient
    {
        #region Private Members

        /// <summary>
        /// The log in information provided by the <see cref="LogInAsync"/> method
        /// </summary>
        private AccessTokenResponseModel? mLogInInformation;

        #endregion

        #region Public Properties

        /// <summary>
        /// The client
        /// </summary>
        public WebRequestsClient Client { get; }

        /// <summary>
        /// The credentials
        /// </summary>
        public ECRAndEFTPOSCommonCredentials Credentials { get; }

        /// <summary>
        /// The base route
        /// </summary>
        public string BaseRoute { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ECRAndEFTPOSCommonClient(ECRAndEFTPOSCommonCredentials credentials, bool shouldUseTestEnvironment = false) : base()
        {
            Client = WebRequestsClient.Instance;

            Credentials = credentials ?? throw new System.ArgumentNullException(nameof(credentials));

            BaseRoute = shouldUseTestEnvironment ? ECRAndEFTPOSCommonRoutes.TestRoute : ECRAndEFTPOSCommonRoutes.ProductionRoute;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Executes a log in operation and returns credentials that can be used for accessing the rest end points
        /// </summary>
        /// <returns></returns>
        public async Task<WebRequestResult<AccessTokenResponseModel>> LogInAsync()
        {
            var response = await Client.PostAsync<AccessTokenResponseModel>(ECRAndEFTPOSCommonRoutes.GetAccessTokenRoute(BaseRoute), Credentials.ToAccessTokenRequestModel(), null);

            if (!response.IsSuccessful)
                return response;

            mLogInInformation = response.Result;

            return response;
        }

        /// <summary>
        /// Gets the terminals
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<IEnumerable<TerminalResponseModel>>> GetTerminalsAsync(TerminalAPIArgs? args = null)
        {
            return ExecuteAsync(
               async x =>
               {
                   var response = await Client.GetAsync<TerminalListResponseModel>(RouteHelpers.AttachParameters(ECRAndEFTPOSCommonRoutes.GetTerminalListRoute(BaseRoute), args), mLogInInformation!.Access);

                   if (!response.IsSuccessful)
                       return response.ToUnsuccessfulWebRequestResult<IEnumerable<TerminalResponseModel>>();

                   return response.ToSuccessfulWebRequestResult(x => x.Results);
               });
        }

        /// <summary>
        /// Gets the terminal list
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<TerminalListResponseModel>> GetTerminalsListAsync()
            => ExecuteAsync(x => Client.GetAsync<TerminalListResponseModel>(ECRAndEFTPOSCommonRoutes.GetTerminalListRoute(BaseRoute), x.Access));

        /// <summary>
        /// Creates a transaction intent using the terminal with the specified <paramref name="terminalId"/>
        /// </summary>
        /// <param name="terminalId">The terminal id</param>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public Task<WebRequestResult<NewTransactionIntentResponseModel>> CreateTransactionIntentAsync(int terminalId, NewTransactionIntentRequestModel model) 
            => ExecuteAsync(x => Client.PostAsync<NewTransactionIntentResponseModel>(ECRAndEFTPOSCommonRoutes.GetNewTransactionIntentRoute(BaseRoute, terminalId), model, x.Access));

        /// <summary>
        /// Gets the transaction intents
        /// </summary>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<IEnumerable<TransactionIntentResponseModel>>> GetTransactionIntentsAsync(TransactionIntentAPIArgs? args = null)
        {
            return ExecuteAsync(
                async x =>
                {
                    var response = await Client.GetAsync<TransactionIntentListResponseModel>(RouteHelpers.AttachParameters(ECRAndEFTPOSCommonRoutes.GetTransactionIntentListRoute(BaseRoute), args), mLogInInformation!.Access);

                    if (!response.IsSuccessful)
                        return response.ToUnsuccessfulWebRequestResult<IEnumerable<TransactionIntentResponseModel>>();

                    return response.ToSuccessfulWebRequestResult(x => x.Results);
                });
        }

        /// <summary>
        /// Gets the transaction intent list
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<TransactionIntentListResponseModel>> GetTransactionIntentListAsync() 
            => ExecuteAsync((x) => Client.GetAsync<TransactionIntentListResponseModel>(ECRAndEFTPOSCommonRoutes.GetTransactionIntentListRoute(BaseRoute), x.Access));

        /// <summary>
        /// Gets the transaction void intents
        /// </summary>
        /// <param name="terminalId">The terminal id</param>
        /// <param name="args">The arguments</param>
        /// <returns></returns>
        public Task<WebRequestResult<IEnumerable<TransactionVoidIntentResponseModel>>> GetTransactionVoidIntentsAsync(int terminalId, TransactionIntentAPIArgs? args = null)
        {
            return ExecuteAsync(
                async x =>
                {
                    var response = await Client.GetAsync<TransactionVoidIntentListResponseModel>(RouteHelpers.AttachParameters(ECRAndEFTPOSCommonRoutes.GetTransactionVoidIntentRoute(BaseRoute, terminalId), args), mLogInInformation!.Access);

                    if (!response.IsSuccessful)
                        return response.ToUnsuccessfulWebRequestResult<IEnumerable<TransactionVoidIntentResponseModel>>();

                    return response.ToSuccessfulWebRequestResult(x => x.Results);
                });
        }

        /// <summary>
        /// Gets the transaction void intent list
        /// </summary>
        /// <returns></returns>
        public Task<WebRequestResult<TransactionVoidIntentListResponseModel>> GetTransactionVoidIntentListAsync(int terminalId)
            => ExecuteAsync((x) => Client.GetAsync<TransactionVoidIntentListResponseModel>(ECRAndEFTPOSCommonRoutes.GetTransactionVoidIntentRoute(BaseRoute, terminalId), x.Access));

        #endregion

        #region Private Methods

        /// <summary>
        /// Executes the specified <paramref name="action"/> after ensuring that a valid JWT has been retrieved.
        /// </summary>
        /// <typeparam name="T">The type of the result.</typeparam>
        /// <param name="action">The action.</param>
        /// <returns></returns>
        private async Task<WebRequestResult<T>> ExecuteAsync<T>(Func<AccessTokenResponseModel, Task<WebRequestResult<T>>> action)
        {
            var info = mLogInInformation;

            if (info is null)
            {
                var logInResponse = await LogInAsync();

                if (!logInResponse.IsSuccessful)
                    return logInResponse.ToUnsuccessfulWebRequestResult<T>();

                info = logInResponse.Result;
            }

            return await action(info);
        }

        #endregion
    }
}