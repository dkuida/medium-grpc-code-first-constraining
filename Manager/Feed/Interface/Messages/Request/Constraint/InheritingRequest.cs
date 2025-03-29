using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Constraint
{
    [ProtoContract]
    public class InheritingRequest : IInheritingRequest
    {
        [ProtoMember(1, IsRequired = true)]
        public required string RequestId { get; set; }

        [ProtoMember(4, IsRequired = true)]
        public required string Message { get; set; }
    }
}