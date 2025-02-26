﻿//HintName: G.Models.MessageBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageBatch
    {
        /// <summary>
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.<br/>
        /// Example: msgbatch_013Zva2CMHLNnXjNJJKqJ2EF
        /// </summary>
        /// <example>msgbatch_013Zva2CMHLNnXjNJJKqJ2EF</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Object type.<br/>
        /// For Message Batches, this is always `"message_batch"`.<br/>
        /// Default Value: message_batch
        /// </summary>
        /// <default>global::G.MessageBatchType.MessageBatch</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageBatchType Type { get; set; } = global::G.MessageBatchType.MessageBatch;

        /// <summary>
        /// Processing status of the Message Batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processing_status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageBatchProcessingStatus ProcessingStatus { get; set; } = default!;

        /// <summary>
        /// Tallies requests within the Message Batch, categorized by their status.<br/>
        /// Requests start as `processing` and move to one of the other statuses only once processing of the entire batch ends. The sum of all values always matches the total number of requests in the batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_counts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RequestCounts RequestCounts { get; set; } = default!;

        /// <summary>
        /// RFC 3339 datetime string representing the time at which processing for the Message Batch ended. Specified only once processing ends.<br/>
        /// Processing ends when every request in a Message Batch has either succeeded, errored, canceled, or expired.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ended_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? EndedAt { get; set; } = default!;

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the Message Batch was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the Message Batch will expire and end processing, which is 24 hours after creation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// RFC 3339 datetime string representing the time at which the Message Batch was archived and its results became unavailable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? ArchivedAt { get; set; } = default!;

        /// <summary>
        /// RFC 3339 datetime string representing the time at which cancellation was initiated for the Message Batch. Specified only if cancellation was initiated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cancel_initiated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? CancelInitiatedAt { get; set; } = default!;

        /// <summary>
        /// URL to a `.jsonl` file containing the results of the Message Batch requests. Specified only once processing ends.<br/>
        /// Results in the file are not guaranteed to be in the same order as requests. Use the `custom_id` field to match results to requests.<br/>
        /// Example: https://api.anthropic.com/v1/messages/batches/msgbatch_013Zva2CMHLNnXjNJJKqJ2EF/results
        /// </summary>
        /// <example>https://api.anthropic.com/v1/messages/batches/msgbatch_013Zva2CMHLNnXjNJJKqJ2EF/results</example>
        [global::Newtonsoft.Json.JsonProperty("results_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ResultsUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatch" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique object identifier.<br/>
        /// The format and length of IDs may change over time.<br/>
        /// Example: msgbatch_013Zva2CMHLNnXjNJJKqJ2EF
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Message Batches, this is always `"message_batch"`.<br/>
        /// Default Value: message_batch
        /// </param>
        /// <param name="processingStatus">
        /// Processing status of the Message Batch.
        /// </param>
        /// <param name="requestCounts">
        /// Tallies requests within the Message Batch, categorized by their status.<br/>
        /// Requests start as `processing` and move to one of the other statuses only once processing of the entire batch ends. The sum of all values always matches the total number of requests in the batch.
        /// </param>
        /// <param name="endedAt">
        /// RFC 3339 datetime string representing the time at which processing for the Message Batch ended. Specified only once processing ends.<br/>
        /// Processing ends when every request in a Message Batch has either succeeded, errored, canceled, or expired.
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 datetime string representing the time at which the Message Batch was created.
        /// </param>
        /// <param name="expiresAt">
        /// RFC 3339 datetime string representing the time at which the Message Batch will expire and end processing, which is 24 hours after creation.
        /// </param>
        /// <param name="archivedAt">
        /// RFC 3339 datetime string representing the time at which the Message Batch was archived and its results became unavailable.
        /// </param>
        /// <param name="cancelInitiatedAt">
        /// RFC 3339 datetime string representing the time at which cancellation was initiated for the Message Batch. Specified only if cancellation was initiated.
        /// </param>
        /// <param name="resultsUrl">
        /// URL to a `.jsonl` file containing the results of the Message Batch requests. Specified only once processing ends.<br/>
        /// Results in the file are not guaranteed to be in the same order as requests. Use the `custom_id` field to match results to requests.<br/>
        /// Example: https://api.anthropic.com/v1/messages/batches/msgbatch_013Zva2CMHLNnXjNJJKqJ2EF/results
        /// </param>
        public MessageBatch(
            string id,
            global::G.MessageBatchProcessingStatus processingStatus,
            global::G.RequestCounts requestCounts,
            global::System.DateTime? endedAt,
            global::System.DateTime createdAt,
            global::System.DateTime expiresAt,
            global::System.DateTime? archivedAt,
            global::System.DateTime? cancelInitiatedAt,
            string? resultsUrl,
            global::G.MessageBatchType type = global::G.MessageBatchType.MessageBatch)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessingStatus = processingStatus;
            this.RequestCounts = requestCounts ?? throw new global::System.ArgumentNullException(nameof(requestCounts));
            this.EndedAt = endedAt;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.ArchivedAt = archivedAt;
            this.CancelInitiatedAt = cancelInitiatedAt;
            this.ResultsUrl = resultsUrl ?? throw new global::System.ArgumentNullException(nameof(resultsUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatch" /> class.
        /// </summary>
        public MessageBatch()
        {
        }
    }
}