﻿//HintName: G.Models.InviteProjectRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project membership role
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InviteProjectRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="member")]
        Member,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InviteProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteProjectRole value)
        {
            return value switch
            {
                InviteProjectRole.Member => "member",
                InviteProjectRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => InviteProjectRole.Member,
                "owner" => InviteProjectRole.Owner,
                _ => null,
            };
        }
    }
}