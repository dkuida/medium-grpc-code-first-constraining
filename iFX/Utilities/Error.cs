using ProtoBuf;

namespace Medium.iFX.Utilities
{
    [ProtoContract]
    public class Error
    {
        private sealed class DescriptionEqualityComparer : IEqualityComparer<Error>
        {
            public bool Equals(Error? x, Error? y)
            {
                if (ReferenceEquals(x, y))
                {
                    return true;
                }

                if (ReferenceEquals(x, null))
                {
                    return false;
                }

                if (ReferenceEquals(y, null))
                {
                    return false;
                }

                if (x.GetType() != y.GetType())
                {
                    return false;
                }

                return x.Description == y.Description;
            }

            public int GetHashCode(Error obj)
            {
                return HashCode.Combine(obj.Description);
            }
        }

        static Error()
        {
            DescriptionComparer = new DescriptionEqualityComparer();
        }

        public static IEqualityComparer<Error> DescriptionComparer 
        { get; }

        public Error():this(string.Empty)
        {

        }

        [ProtoMember(1)]
        public int Level
        { get; set; }

        [ProtoMember(2)]
        public string Description
        { get; set; }

        public Error(string description)
        {
            Description = description;
        }

        public Error(Exception e)
        {
            Description = e.Message;
        }

        public override string ToString()
        {
            return Description;
        }

        public static implicit operator Error(Exception e)
        {
            return new Error($"Message: {e.Message}, StackTrace: {e.StackTrace}"){Level = 0};
        }
    }
}
