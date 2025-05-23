﻿//HintName: G.Models.OrganizationActionsVariableVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Visibility of a variable
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationActionsVariableVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationActionsVariableVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationActionsVariableVisibility value)
        {
            return value switch
            {
                OrganizationActionsVariableVisibility.All => "all",
                OrganizationActionsVariableVisibility.Private => "private",
                OrganizationActionsVariableVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationActionsVariableVisibility? ToEnum(string value)
        {
            return value switch
            {
                "all" => OrganizationActionsVariableVisibility.All,
                "private" => OrganizationActionsVariableVisibility.Private,
                "selected" => OrganizationActionsVariableVisibility.Selected,
                _ => null,
            };
        }
    }
}