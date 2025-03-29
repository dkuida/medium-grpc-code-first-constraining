using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Problem
{
    [ProtoContract]
    public class BaseRequest
    {
        [ProtoMember(1, IsRequired = true)]
        public required string RequestId { get; set; }
    }
}