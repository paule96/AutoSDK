﻿//HintName: G.Models.BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost
    {
        /// <summary>
        /// Whether to convert the audio to mpeg format.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("convert_to_mpeg")]
        public bool? ConvertToMpeg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost" /> class.
        /// </summary>
        /// <param name="convertToMpeg">
        /// Whether to convert the audio to mpeg format.<br/>
        /// Default Value: false
        /// </param>
        public BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost(
            bool? convertToMpeg)
        {
            this.ConvertToMpeg = convertToMpeg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost" /> class.
        /// </summary>
        public BodyStreamStudioProjectAudioV1StudioProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost()
        {
        }
    }
}