using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Constraint
{
    [ProtoContract]
    public class OtherRequest : IOtherRequest
    {
        [ProtoMember(1, IsRequired = true)]
        public required string RequestId { get; set; }

        [ProtoMember(2, IsRequired = true)]
        public required string OtherProperty { get; set; }
    }
}