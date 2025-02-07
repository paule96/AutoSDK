﻿//HintName: G.Models.CreditTransaction2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreditTransaction2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        public global::System.Guid? AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditDate")]
        public global::System.DateTime? CreditDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDebit")]
        public bool? IsDebit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prevBal")]
        public double? PrevBal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remBal")]
        public double? RemBal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memo")]
        public string? Memo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditTransaction2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="accountId"></param>
        /// <param name="creditDate"></param>
        /// <param name="amount"></param>
        /// <param name="isDebit"></param>
        /// <param name="prevBal"></param>
        /// <param name="remBal"></param>
        /// <param name="memo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditTransaction2(
            global::System.Guid? id,
            global::System.Guid? accountId,
            global::System.DateTime? creditDate,
            double? amount,
            bool? isDebit,
            double? prevBal,
            double? remBal,
            string? memo)
        {
            this.Id = id;
            this.AccountId = accountId;
            this.CreditDate = creditDate;
            this.Amount = amount;
            this.IsDebit = isDebit;
            this.PrevBal = prevBal;
            this.RemBal = remBal;
            this.Memo = memo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditTransaction2" /> class.
        /// </summary>
        public CreditTransaction2()
        {
        }
    }
}