﻿//HintName: G.Models.ProjectUserDeleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUserDeleteResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ProjectUserDeleteResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUserDeleteResponse" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="id"></param>
        /// <param name="deleted"></param>
        public ProjectUserDeleteResponse(
            string id,
            bool deleted,
            global::G.ProjectUserDeleteResponseObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUserDeleteResponse" /> class.
        /// </summary>
        public ProjectUserDeleteResponse()
        {
        }
    }
}