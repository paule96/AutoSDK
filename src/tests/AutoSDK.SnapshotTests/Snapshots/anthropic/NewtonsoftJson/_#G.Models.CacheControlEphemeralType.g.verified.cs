﻿//HintName: G.Models.CacheControlEphemeralType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CacheControlEphemeralType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ephemeral")]
        Ephemeral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CacheControlEphemeralTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CacheControlEphemeralType value)
        {
            return value switch
            {
                CacheControlEphemeralType.Ephemeral => "ephemeral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CacheControlEphemeralType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => CacheControlEphemeralType.Ephemeral,
                _ => null,
            };
        }
    }
}