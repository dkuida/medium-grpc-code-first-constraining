using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Official
{
    [ProtoContract]
    [ProtoInclude(101, typeof(OtherResponse))]
    [ProtoInclude(102, typeof(InheritingResponse))]
    public class BaseResponse
    {
        [ProtoMember(1, IsRequired = true)]
        public required bool Success { get; set; }
    }
}