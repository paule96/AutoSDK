﻿//HintName: G.Models.ResponseFormatTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of response format being defined. Always `text`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFormatTextType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatTextType value)
        {
            return value switch
            {
                ResponseFormatTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ResponseFormatTextType.Text,
                _ => null,
            };
        }
    }
}