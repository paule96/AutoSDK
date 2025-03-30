﻿//HintName: G.Models.ChapterSnapshotsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterSnapshotsResponseModel
    {
        /// <summary>
        /// List of chapter snapshots.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snapshots", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChapterSnapshotResponseModel> Snapshots { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterSnapshotsResponseModel" /> class.
        /// </summary>
        /// <param name="snapshots">
        /// List of chapter snapshots.
        /// </param>
        public ChapterSnapshotsResponseModel(
            global::System.Collections.Generic.IList<global::G.ChapterSnapshotResponseModel> snapshots)
        {
            this.Snapshots = snapshots ?? throw new global::System.ArgumentNullException(nameof(snapshots));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterSnapshotsResponseModel" /> class.
        /// </summary>
        public ChapterSnapshotsResponseModel()
        {
        }
    }
}