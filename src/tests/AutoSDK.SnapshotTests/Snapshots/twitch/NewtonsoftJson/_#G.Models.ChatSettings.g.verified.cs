﻿//HintName: G.Models.ChatSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatSettings
    {
        /// <summary>
        /// The ID of the broadcaster specified in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether chat messages must contain only emotes. Is **true** if chat messages may contain only emotes; otherwise, **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emote_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public bool EmoteMode { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the broadcaster restricts the chat room to followers only.  <br/>
        ///   <br/>
        /// Is **true** if the broadcaster restricts the chat room to followers only; otherwise, **false**.  <br/>
        ///   <br/>
        /// See the `follower_mode_duration` field for how long users must follow the broadcaster before being able to participate in the chat room.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("follower_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public bool FollowerMode { get; set; } = default!;

        /// <summary>
        /// The length of time, in minutes, that users must follow the broadcaster before being able to participate in the chat room. Is **null** if `follower_mode` is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("follower_mode_duration", Required = global::Newtonsoft.Json.Required.Always)]
        public int? FollowerModeDuration { get; set; } = default!;

        /// <summary>
        /// The moderator’s ID. The response includes this field only if the request specifies a user access token that includes the **moderator:read:chat\_settings** scope.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_id")]
        public string? ModeratorId { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. This gives chat moderators and bots a chance to remove them before viewers can see the message. See the `non_moderator_chat_delay_duration` field for the length of the delay. Is **true** if the broadcaster applies a delay; otherwise, **false**.  <br/>
        ///   <br/>
        /// The response includes this field only if the request specifies a user access token that includes the **moderator:read:chat\_settings** scope and the user in the _moderator\_id_ query parameter is one of the broadcaster’s moderators.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("non_moderator_chat_delay")]
        public bool? NonModeratorChatDelay { get; set; }

        /// <summary>
        /// The amount of time, in seconds, that messages are delayed before appearing in chat. Is **null** if `non_moderator_chat_delay` is **false**.  <br/>
        ///   <br/>
        /// The response includes this field only if the request specifies a user access token that includes the **moderator:read:chat\_settings** scope and the user in the _moderator\_id_ query parameter is one of the broadcaster’s moderators.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("non_moderator_chat_delay_duration")]
        public int? NonModeratorChatDelayDuration { get; set; }

        /// <summary>
        /// A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages.  <br/>
        ///   <br/>
        /// Is **true** if the broadcaster applies a delay; otherwise, **false**.  <br/>
        ///   <br/>
        /// See the `slow_mode_wait_time` field for the delay.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slow_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SlowMode { get; set; } = default!;

        /// <summary>
        /// The amount of time, in seconds, that users must wait between sending messages.  <br/>
        ///   <br/>
        /// Is **null** if slow\_mode is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slow_mode_wait_time", Required = global::Newtonsoft.Json.Required.Always)]
        public int? SlowModeWaitTime { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether only users that subscribe to the broadcaster’s channel may talk in the chat room.  <br/>
        ///   <br/>
        /// Is **true** if the broadcaster restricts the chat room to subscribers only; otherwise, **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriber_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public bool SubscriberMode { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.  <br/>
        ///   <br/>
        /// Is **true** if the broadcaster requires unique messages only; otherwise, **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unique_chat_mode", Required = global::Newtonsoft.Json.Required.Always)]
        public bool UniqueChatMode { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSettings" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster specified in the request.
        /// </param>
        /// <param name="emoteMode">
        /// A Boolean value that determines whether chat messages must contain only emotes. Is **true** if chat messages may contain only emotes; otherwise, **false**.
        /// </param>
        /// <param name="followerMode">
        /// A Boolean value that determines whether the broadcaster restricts the chat room to followers only.  <br/>
        ///   <br/>
        /// Is **true** if the broadcaster restricts the chat room to followers only; otherwise, **false**.  <br/>
        ///   <br/>
        /// See the `follower_mode_duration` field for how long users must follow the broadcaster before being able to participate in the chat room.
        /// </param>
        /// <param name="followerModeDuration">
        /// The length of time, in minutes, that users must follow the broadcaster before being able to participate in the chat room. Is **null** if `follower_mode` is **false**.
        /// </param>
        /// <param name="moderatorId">
        /// The moderator’s ID. The response includes this field only if the request specifies a user access token that includes the **moderator:read:chat\_settings** scope.
        /// </param>
        /// <param name="nonModeratorChatDelay">
        /// A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. This gives chat moderators and bots a chance to remove them before viewers can see the message. See the `non_moderator_chat_delay_duration` field for the length of the delay. Is **true** if the broadcaster applies a delay; otherwise, **false**.  <br/>
        ///   <br/>
        /// The response includes this field only if the request specifies a user access token that includes the **moderator:read:chat\_settings** scope and the user in the _moderator\_id_ query parameter is one of the broadcaster’s moderators.
        /// </param>
        /// <param name="nonModeratorChatDelayDuration">
        /// The amount of time, in seconds, that messages are delayed before appearing in chat. Is **null** if `non_moderator_chat_delay` is **false**.  <br/>
        ///   <br/>
        /// The response includes this field only if the request specifies a user access token that includes the **moderator:read:chat\_settings** scope and the user in the _moderator\_id_ query parameter is one of the broadcaster’s moderators.
        /// </param>
        /// <param name="slowMode">
        /// A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages.  <br/>
        ///   <br/>
        /// Is **true** if the broadcaster applies a delay; otherwise, **false**.  <br/>
        ///   <br/>
        /// See the `slow_mode_wait_time` field for the delay.
        /// </param>
        /// <param name="slowModeWaitTime">
        /// The amount of time, in seconds, that users must wait between sending messages.  <br/>
        ///   <br/>
        /// Is **null** if slow\_mode is **false**.
        /// </param>
        /// <param name="subscriberMode">
        /// A Boolean value that determines whether only users that subscribe to the broadcaster’s channel may talk in the chat room.  <br/>
        ///   <br/>
        /// Is **true** if the broadcaster restricts the chat room to subscribers only; otherwise, **false**.
        /// </param>
        /// <param name="uniqueChatMode">
        /// A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.  <br/>
        ///   <br/>
        /// Is **true** if the broadcaster requires unique messages only; otherwise, **false**.
        /// </param>
        public ChatSettings(
            string broadcasterId,
            bool emoteMode,
            bool followerMode,
            int? followerModeDuration,
            bool slowMode,
            int? slowModeWaitTime,
            bool subscriberMode,
            bool uniqueChatMode,
            string? moderatorId,
            bool? nonModeratorChatDelay,
            int? nonModeratorChatDelayDuration)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.EmoteMode = emoteMode;
            this.FollowerMode = followerMode;
            this.FollowerModeDuration = followerModeDuration;
            this.SlowMode = slowMode;
            this.SlowModeWaitTime = slowModeWaitTime;
            this.SubscriberMode = subscriberMode;
            this.UniqueChatMode = uniqueChatMode;
            this.ModeratorId = moderatorId;
            this.NonModeratorChatDelay = nonModeratorChatDelay;
            this.NonModeratorChatDelayDuration = nonModeratorChatDelayDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSettings" /> class.
        /// </summary>
        public ChatSettings()
        {
        }
    }
}