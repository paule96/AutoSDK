﻿//HintName: G.Models.WebhookInstallationRepositoriesRemovedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookInstallationRepositoriesRemovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="removed")]
        Removed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookInstallationRepositoriesRemovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookInstallationRepositoriesRemovedAction value)
        {
            return value switch
            {
                WebhookInstallationRepositoriesRemovedAction.Removed => "removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookInstallationRepositoriesRemovedAction? ToEnum(string value)
        {
            return value switch
            {
                "removed" => WebhookInstallationRepositoriesRemovedAction.Removed,
                _ => null,
            };
        }
    }
}