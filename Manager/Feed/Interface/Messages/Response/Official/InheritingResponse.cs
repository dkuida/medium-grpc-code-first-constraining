using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Official
{
    [ProtoContract]
    public class InheritingResponse : BaseResponse
    {
        [ProtoMember(2, IsRequired = true)]
        public required string Message { get; set; }
    }
}