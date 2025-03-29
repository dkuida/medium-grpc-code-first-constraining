using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Constraint
{
    [ProtoContract]
    public class BaseRequest : IBaseRequest
    {
        [ProtoMember(1, IsRequired = true)]
        public required string RequestId { get; set; }
    }
}