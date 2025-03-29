using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages
{
    [ProtoContract]
    public class OtherConstrainedRequest
    {
        [ProtoMember(1, IsRequired = true)]
        public required string RequestId { get; set; }
    }
}