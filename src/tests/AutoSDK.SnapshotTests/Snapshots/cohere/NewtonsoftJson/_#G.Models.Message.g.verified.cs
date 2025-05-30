﻿//HintName: G.Models.Message.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Message : global::System.IEquatable<Message>
    {
        /// <summary>
        /// Represents a single message in the chat history, excluding the current user turn. It has two properties: `role` and `message`. The `role` identifies the sender (`CHATBOT`, `SYSTEM`, or `USER`), while the `message` contains the text content.<br/>
        /// The chat_history parameter should not be used for `SYSTEM` messages in most cases. Instead, to add a `SYSTEM` role message at the beginning of a conversation, the `preamble` parameter should be used.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatMessage? Chat { get; init; }
#else
        public global::G.ChatMessage? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::G.ChatMessage value) => new Message((global::G.ChatMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatMessage?(Message @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::G.ChatMessage? value)
        {
            Chat = value;
        }

        /// <summary>
        /// Represents tool result in the chat history.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolMessage? Tool { get; init; }
#else
        public global::G.ToolMessage? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Message(global::G.ToolMessage value) => new Message((global::G.ToolMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolMessage?(Message @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public Message(global::G.ToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Message(
            global::G.ChatMessage? chat,
            global::G.ToolMessage? tool
            )
        {
            Chat = chat;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            Chat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Chat?.ToString() ??
            Tool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChat && !IsTool || !IsChat && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatMessage?, TResult>? chat = null,
            global::System.Func<global::G.ToolMessage?, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChat && chat != null)
            {
                return chat(Chat!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatMessage?>? chat = null,
            global::System.Action<global::G.ToolMessage?>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Chat,
                typeof(global::G.ChatMessage),
                Tool,
                typeof(global::G.ToolMessage),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Message other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatMessage?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolMessage?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Message obj1, Message obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Message>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Message obj1, Message obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Message o && Equals(o);
        }
    }
}
