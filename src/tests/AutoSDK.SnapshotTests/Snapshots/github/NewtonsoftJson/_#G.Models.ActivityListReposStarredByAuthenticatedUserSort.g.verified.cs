﻿//HintName: G.Models.ActivityListReposStarredByAuthenticatedUserSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: created
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActivityListReposStarredByAuthenticatedUserSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="updated")]
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityListReposStarredByAuthenticatedUserSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityListReposStarredByAuthenticatedUserSort value)
        {
            return value switch
            {
                ActivityListReposStarredByAuthenticatedUserSort.Created => "created",
                ActivityListReposStarredByAuthenticatedUserSort.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityListReposStarredByAuthenticatedUserSort? ToEnum(string value)
        {
            return value switch
            {
                "created" => ActivityListReposStarredByAuthenticatedUserSort.Created,
                "updated" => ActivityListReposStarredByAuthenticatedUserSort.Updated,
                _ => null,
            };
        }
    }
}