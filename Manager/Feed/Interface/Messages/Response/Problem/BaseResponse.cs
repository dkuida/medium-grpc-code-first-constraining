using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Problem
{
    [ProtoContract]
    public class BaseResponse
    {
        [ProtoMember(1, IsRequired = true)]
        public required bool Success { get; set; }
    }
}