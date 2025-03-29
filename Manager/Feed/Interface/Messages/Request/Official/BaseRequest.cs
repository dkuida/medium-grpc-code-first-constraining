using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Official
{

    [ProtoContract]
    [ProtoInclude(101, typeof(OtherRequest))]
    [ProtoInclude(102, typeof(InheritingRequest))]
    public class BaseRequest
    {
        [ProtoMember(1, IsRequired = true)]
        public required string RequestId { get; set; }
    }
}