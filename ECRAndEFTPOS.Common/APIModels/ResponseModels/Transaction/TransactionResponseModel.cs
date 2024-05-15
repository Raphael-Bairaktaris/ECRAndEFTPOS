using Newtonsoft.Json;
using System;

namespace ECRAndEFTPOS.Common
{
    /// <summary>
    /// Represents a transaction
    /// </summary>
    public class TransactionResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="CardHash"/> property
        /// </summary>
        private string? mCardHash;

        /// <summary>
        /// The member of the <see cref="Cryptogram"/> property
        /// </summary>
        private string? mCryptogram;

        /// <summary>
        /// The member of the <see cref="Voucher"/> property
        /// </summary>
        private string? mVoucher;

        #endregion

        #region Public Properties

        /// <summary>
        /// The unique identifier of the transaction for the POS backend
        /// </summary>
        /// <example>8091750</example>
        [JsonProperty("TxnId")]
        public int TransactionId { get; set; }

        /// <summary>
        /// The transaction type.
        /// </summary>
        /// <example>0 for sale</example>
        [JsonProperty("TransactionType")]
        [JsonConverter(typeof(TransactionTypeToIntJsonConverter))]
        public TransactionType TransactionType { get; set; }

        /// <summary>
        /// The transaction completion timestamp in ISO-8601 format
        /// </summary>
        [JsonProperty("Timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// A unique hash for the card PAN
        /// </summary>
        /// <example>516732******6411</example>
        [JsonProperty("CardPAN")]
        public int CardPAN { get; set; }

        /// <summary>
        /// A unique hash for the card PAN
        /// </summary>
        [JsonProperty("CardHash")]
        public string CardHash
        {
            get => mCardHash ?? string.Empty;
            set => mCardHash = value;
        }

        /// <summary>
        /// Indicates whether the transaction is approved
        /// </summary>
        [JsonProperty("Approved")]
        public bool IsApproved { get; set; }

        /// <summary>
        /// Indicates whether the transaction is voided
        /// </summary>
        [JsonProperty("Voided")]
        public bool IsVoided { get; set; }

        /// <summary>
        /// The System Trace Audit Number (STAN) of the transaction as set by the authorization system
        /// </summary>
        /// <example>1</example>
        [JsonProperty("STAN")]
        public int STAN { get; set; }

        /// <summary>
        /// The number of the batch this transaction belongs to
        /// </summary>
        /// <example>1</example>
        [JsonProperty("BatchNumber")]
        public int BatchNumber { get; set; }

        /// <summary>
        /// The unique identifier of the batch for the POS backend.
        /// May be null if the batch hasn't closed yet
        /// </summary>
        [JsonProperty("Batch")]
        public int Batch { get; set; }

        /// <summary>
        /// Terminal Id of the terminal the performed the transaction
        /// </summary>
        /// <example>90000001</example>
        [JsonProperty("TID")]
        public int TerminalId { get; set; }

        /// <summary>
        /// Merchant Id of the terminal that performed the transaction
        /// </summary>
        [JsonProperty("MID")]
        public int MerchantId { get; set; }

        /// <summary>
        /// The transaction amount in integer form
        /// </summary>
        /// <example>1.00eur is 100</example>
        [JsonProperty("Amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The transaction tip amount in integer form
        /// </summary>
        /// <example>1.00eur is 100</example>
        [JsonProperty("TipAmount")]
        public decimal TipAmount { get; set; }

        /// <summary>
        /// The transaction cashback amount in integer form
        /// </summary>
        /// <example>1.00eur is 100</example>
        [JsonProperty("CashbackAmount")]
        public decimal CashbackAmount { get; set; }

        /// <summary>
        /// The transaction loyalty redemption amount in integer form
        /// </summary>
        /// <example>1.00eur is 100</example>
        [JsonProperty("LoyaltyRedemptionAmount")]
        public decimal LoyaltyRedemptionAmount { get; set; }

        /// <summary>
        /// The number of instalments
        /// </summary>
        /// <example>0</example>
        [JsonProperty("Instalments")]
        public int Instalments { get; set; }

        /// <summary>
        /// The mode that the card was read by the POS
        /// </summary>
        /// <example>73</example>
        [JsonProperty("PosEntryMode")]
        public int POSEntryMode { get; set; }

        /// <summary>
        /// The EMV transaction cryptogram (in case of chip or contact-less transaction)
        /// </summary>
        /// <example>2A662842E6907737</example>
        [JsonProperty("Cryptogram")]
        public string Cryptogram
        {
            get => mCryptogram ?? string.Empty;
            set => mCryptogram = value;
        }

        /// <summary>
        /// The response code of the authorization system
        /// </summary>
        /// <example>000</example>
        [JsonProperty("HostResponseCode")]
        public int HostResponseCode { get; set; }

        /// <summary>
        /// The retrieval reference number of the authorization system
        /// </summary>
        [JsonProperty("RRN")]
        public int RetrievalReferenceNumber { get; set; }

        /// <summary>
        /// The authorization code of the authorization system
        /// </summary>
        [JsonProperty("AuthCode")]
        public int AuthorizationCode { get; set; }

        /// <summary>
        /// The RRN of the initial transaction - only applicable if TransactionType = REFUND
        /// </summary>
        [JsonProperty("OriginalRRN")]
        public int OriginalRetrievalReferenceNumber { get; set; }

        /// <summary>
        /// The authorization code of the initial transaction - only applicable if TransactionType = REFUND
        /// </summary>
        [JsonProperty("OriginalAuthCode")]
        public int OriginalAuthorizationCode { get; set; }

        /// <summary>
        /// The ISO-4217 numerical currency code 
        /// </summary>
        /// <example>978 for EUR</example>
        [JsonProperty("CurrencyCode")]
        [JsonConverter(typeof(CurrencyCodeToIntJsonConverter))]
        public CurrencyCode CurrencyCode { get; set; }

        /// <summary>
        /// The customer defined reference used to reference the transaction in 3rd party systems
        /// </summary>
        /// <example>"b7775c92-0be9-4005-9450-e45769e593e2</example>
        [JsonProperty("Voucher")]
        public string Voucher
        {
            get => mVoucher ?? string.Empty;
            set => mVoucher = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public TransactionResponseModel() : base()
        {

        }

        #endregion
    }
}