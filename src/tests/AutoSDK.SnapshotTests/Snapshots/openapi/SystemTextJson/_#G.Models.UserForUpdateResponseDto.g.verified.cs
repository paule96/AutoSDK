﻿//HintName: G.Models.UserForUpdateResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserForUpdateResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForUpdateResponseDto" /> class.
        /// </summary>
        /// <param name="success"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserForUpdateResponseDto(
            bool? success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserForUpdateResponseDto" /> class.
        /// </summary>
        public UserForUpdateResponseDto()
        {
        }
    }
}