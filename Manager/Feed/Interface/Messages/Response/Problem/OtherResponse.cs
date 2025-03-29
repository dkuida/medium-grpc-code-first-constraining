using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Problem
{
    [ProtoContract]
    public class OtherResponse : BaseResponse
    {
        [ProtoMember(3, IsRequired = true)]
        public required string OtherProperty { get; set; }
    }
}