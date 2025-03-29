using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Problem
{
    [ProtoContract]
    public class OtherRequest : BaseRequest
    {
        [ProtoMember(2, IsRequired = true)]
        public required string OtherProperty { get; set; }
    }
}