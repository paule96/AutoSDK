﻿//HintName: G.Models.CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Automatic dependency submission<br/>
    /// Default Value: disabled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_set")]
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitAction.NotSet,
                _ => null,
            };
        }
    }
}