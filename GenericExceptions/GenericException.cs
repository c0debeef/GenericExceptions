using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace c0debeef.Exceptions
{
    public static class GenericExceptionExtention
    {
        [DebuggerStepThrough] [MethodImpl(MethodImplOptions.AggressiveInlining)] public static ExceptionDispatchInfo Capture(this Exception self) => ExceptionDispatchInfo.Capture(self);
        [DebuggerStepThrough] [MethodImpl(MethodImplOptions.AggressiveInlining)] public static void Throw(this Exception self) { ExceptionDispatchInfo.Capture(self).Throw(); }
    }

    [Serializable]
    public partial class GenericException : Exception
    {
        public GenericException() : base(null, null) { }
        protected GenericException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static GenericException Create() => new GenericException();
        public override string Message => this.ToString();
        public override string ToString() => $@"{nameof(GenericException)}()";
        public override int GetHashCode() => unchecked((int)0xc0debeef);
        public override bool Equals(object other) => Equals(other as GenericException);
        protected bool Equals(GenericException other) => (null != other) && this.GetHashCode() == other.GetHashCode();
    }
    public partial class GenericException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static GenericException<T1> Create<T1>(T1 first) => new GenericException<T1>(first);
    }

    [Serializable]
    public class GenericException<T1> : GenericException
    {
        public T1 First { get; protected set; }
        public GenericException(T1 first)
        {
            this.First = first;
        }
        protected GenericException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this.First = (T1)info.GetValue(nameof(this.First), typeof(T1));
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(this.First), this.First, typeof(T1));
        }
        public override string ToString() => $@"{nameof(GenericException<T1>)}<{typeof(T1)}>({this.First})";
        public override int GetHashCode() => unchecked(~base.GetHashCode() ^ (this.First?.GetHashCode() ?? typeof(T1).GUID.GetHashCode()));
        public override bool Equals(object other) => Equals(other as GenericException<T1>);
        protected bool Equals(GenericException<T1> other) => (null != other) && this.GetHashCode() == other.GetHashCode();
    }
    public partial class GenericException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static GenericException<T1, T2> Create<T1, T2>(T1 first, T2 second) => new GenericException<T1, T2>(first, second);
    }

    [Serializable]
    public class GenericException<T1, T2> : GenericException<T1>
    {
        public T2 Second { get; protected set; }
        public GenericException(T1 first, T2 second) : base(first)
        {
            this.Second = second;
        }
        protected GenericException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this.Second = (T2)info.GetValue(nameof(this.Second), typeof(T2));
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(this.Second), this.Second, typeof(T2));
        }
        public override string ToString() => $@"{nameof(GenericException<T1, T2>)}<{typeof(T1)},{typeof(T2)}>({this.First},{this.Second})";

        public override int GetHashCode() => unchecked(~base.GetHashCode() ^ (this.Second?.GetHashCode() ?? typeof(T2).GUID.GetHashCode()));
        public override bool Equals(object other) => Equals(other as GenericException<T1, T2>);
        protected bool Equals(GenericException<T1, T2> other) => (null != other) && this.GetHashCode() == other.GetHashCode();
    }
    public partial class GenericException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static GenericException<T1, T2, T3> Create<T1, T2, T3>(T1 first, T2 second, T3 third) => new GenericException<T1, T2, T3>(first, second, third);
    }

    [Serializable]
    public class GenericException<T1, T2, T3> : GenericException<T1, T2>
    {
        public T3 Third { get; protected set; }
        public GenericException(T1 first, T2 second, T3 third) : base(first, second)
        {
            this.Third = third;
        }
        protected GenericException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this.Third = (T3)info.GetValue(nameof(this.Third), typeof(T3));
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(this.Third), this.Third, typeof(T3));
        }
        public override string ToString() => $@"{nameof(GenericException<T1, T2, T3>)}<{typeof(T1)},{typeof(T2)},{typeof(T3)}>({this.First},{this.Second},{this.Third})";
        public override int GetHashCode() => unchecked(~base.GetHashCode() ^ (this.Third?.GetHashCode() ?? typeof(T3).GUID.GetHashCode()));
        public override bool Equals(object other) => Equals(other as GenericException<T1, T2, T3>);
        protected bool Equals(GenericException<T1, T2, T3> other) => (null != other) && this.GetHashCode() == other.GetHashCode();
    }
    public partial class GenericException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static GenericException<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 first, T2 second, T3 third, T4 fourth) => new GenericException<T1, T2, T3, T4>(first, second, third, fourth);
    }

    [Serializable]
    public class GenericException<T1, T2, T3, T4> : GenericException<T1, T2, T3>
    {
        public T4 Fourth { get; protected set; }
        public GenericException(T1 first, T2 second, T3 third, T4 fourth) : base(first, second, third)
        {
            this.Fourth = fourth;
        }
        protected GenericException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this.Fourth = (T4)info.GetValue(nameof(this.Fourth), typeof(T4));
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(this.Fourth), this.Fourth, typeof(T4));
        }
        public override string ToString() => $@"{nameof(GenericException<T1, T2, T3, T4>)}<{typeof(T1)},{typeof(T2)},{typeof(T3)},{typeof(T4)}>({this.First},{this.Second},{this.Third},{this.Fourth})";
        public override int GetHashCode() => unchecked(~base.GetHashCode() ^ (this.Fourth?.GetHashCode() ?? typeof(T4).GUID.GetHashCode()));
        public override bool Equals(object other) => Equals(other as GenericException<T1, T2, T3, T4>);
        protected bool Equals(GenericException<T1, T2, T3, T4> other) => (null != other) && this.GetHashCode() == other.GetHashCode();
    }

    public partial class GenericException
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public static GenericException<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 first, T2 second, T3 third, T4 fourth, T5 fifth) => new GenericException<T1, T2, T3, T4, T5>(first, second, third, fourth, fifth);
    }

    [Serializable]
    public class GenericException<T1, T2, T3, T4, T5> : GenericException<T1, T2, T3, T4>
    {
        public T5 Fifth { get; protected set; }
        public GenericException(T1 first, T2 second, T3 third, T4 fourth, T5 fifth) : base(first, second, third, fourth)
        {
            this.Fifth = fifth;
        }
        protected GenericException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            this.Fifth = (T5)info.GetValue(nameof(this.Fifth), typeof(T5));
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(this.Fifth), this.Fifth, typeof(T5));
        }
        public override string ToString() => $@"{nameof(GenericException<T1, T2, T3, T4, T5>)}<{typeof(T1)},{typeof(T2)},{typeof(T3)},{typeof(T4)},{typeof(T5)}>({this.First},{this.Second},{this.Third},{this.Fourth},{this.Fifth})";
        public override int GetHashCode() => unchecked(~base.GetHashCode() ^ (this.Fifth?.GetHashCode() ?? typeof(T5).GUID.GetHashCode()));
        public override bool Equals(object other) => Equals(other as GenericException<T1, T2, T3, T4, T5>);
        protected bool Equals(GenericException<T1, T2, T3, T4, T5> other) => (null != other) && this.GetHashCode() == other.GetHashCode();
    }
}
