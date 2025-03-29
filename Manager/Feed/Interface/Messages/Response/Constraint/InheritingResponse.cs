using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Constraint
{
    [ProtoContract]
    public class InheritingResponse : IInheritingResponse
    {
        [ProtoMember(1, IsRequired = true)]
        public bool Success { get; set; }

        [ProtoMember(2, IsRequired = true)]
        public required string Message { get; set; }
    }
}