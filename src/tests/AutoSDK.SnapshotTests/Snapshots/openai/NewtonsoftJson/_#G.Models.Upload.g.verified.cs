﻿//HintName: G.Models.Upload.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The Upload object can accept byte chunks in the form of Parts.
    /// </summary>
    public sealed partial class Upload
    {
        /// <summary>
        /// The Upload unique identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the Upload was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the file to be uploaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The intended number of bytes to be uploaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Bytes { get; set; } = default!;

        /// <summary>
        /// The intended purpose of the file. [Please refer here](/docs/api-reference/files/object#files/object-purpose) for acceptable values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose", Required = global::Newtonsoft.Json.Required.Always)]
        public string Purpose { get; set; } = default!;

        /// <summary>
        /// The status of the Upload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UploadStatus Status { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the Upload will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "upload".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.UploadObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public global::G.AllOf<global::G.OpenAIFile, object>? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Upload" /> class.
        /// </summary>
        /// <param name="id">
        /// The Upload unique identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the Upload was created.
        /// </param>
        /// <param name="filename">
        /// The name of the file to be uploaded.
        /// </param>
        /// <param name="bytes">
        /// The intended number of bytes to be uploaded.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the file. [Please refer here](/docs/api-reference/files/object#files/object-purpose) for acceptable values.
        /// </param>
        /// <param name="status">
        /// The status of the Upload.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the Upload will expire.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "upload".
        /// </param>
        /// <param name="file"></param>
        public Upload(
            string id,
            global::System.DateTimeOffset createdAt,
            string filename,
            int bytes,
            string purpose,
            global::G.UploadStatus status,
            global::System.DateTimeOffset expiresAt,
            global::G.UploadObject? @object,
            global::G.AllOf<global::G.OpenAIFile, object>? file)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Bytes = bytes;
            this.Purpose = purpose ?? throw new global::System.ArgumentNullException(nameof(purpose));
            this.Status = status;
            this.ExpiresAt = expiresAt;
            this.Object = @object;
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Upload" /> class.
        /// </summary>
        public Upload()
        {
        }
    }
}