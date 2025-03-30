﻿//HintName: G.Models.RetrieveModelV1ModelsModelIdGetResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RetrieveModelV1ModelsModelIdGetResponse : global::System.IEquatable<RetrieveModelV1ModelsModelIdGetResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BaseModelCard? Base { get; init; }
#else
        public global::G.BaseModelCard? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetrieveModelV1ModelsModelIdGetResponse(global::G.BaseModelCard value) => new RetrieveModelV1ModelsModelIdGetResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BaseModelCard?(RetrieveModelV1ModelsModelIdGetResponse @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public RetrieveModelV1ModelsModelIdGetResponse(global::G.BaseModelCard? value)
        {
            Base = value;
        }

        /// <summary>
        /// Extra fields for fine-tuned models.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FTModelCard? FineTuned { get; init; }
#else
        public global::G.FTModelCard? FineTuned { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FineTuned))]
#endif
        public bool IsFineTuned => FineTuned != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RetrieveModelV1ModelsModelIdGetResponse(global::G.FTModelCard value) => new RetrieveModelV1ModelsModelIdGetResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FTModelCard?(RetrieveModelV1ModelsModelIdGetResponse @this) => @this.FineTuned;

        /// <summary>
        /// 
        /// </summary>
        public RetrieveModelV1ModelsModelIdGetResponse(global::G.FTModelCard? value)
        {
            FineTuned = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RetrieveModelV1ModelsModelIdGetResponse(
            global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType? type,
            global::G.BaseModelCard? @base,
            global::G.FTModelCard? fineTuned
            )
        {
            Type = type;

            Base = @base;
            FineTuned = fineTuned;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FineTuned as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            FineTuned?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && !IsFineTuned || !IsBase && IsFineTuned;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BaseModelCard?, TResult>? @base = null,
            global::System.Func<global::G.FTModelCard?, TResult>? fineTuned = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsFineTuned && fineTuned != null)
            {
                return fineTuned(FineTuned!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BaseModelCard?>? @base = null,
            global::System.Action<global::G.FTModelCard?>? fineTuned = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsFineTuned)
            {
                fineTuned?.Invoke(FineTuned!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.BaseModelCard),
                FineTuned,
                typeof(global::G.FTModelCard),
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
        public bool Equals(RetrieveModelV1ModelsModelIdGetResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BaseModelCard?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FTModelCard?>.Default.Equals(FineTuned, other.FineTuned) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RetrieveModelV1ModelsModelIdGetResponse obj1, RetrieveModelV1ModelsModelIdGetResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RetrieveModelV1ModelsModelIdGetResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RetrieveModelV1ModelsModelIdGetResponse obj1, RetrieveModelV1ModelsModelIdGetResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RetrieveModelV1ModelsModelIdGetResponse o && Equals(o);
        }
    }
}
