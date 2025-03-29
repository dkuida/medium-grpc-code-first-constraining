using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Constraint
{
    [ProtoContract]
    public class BaseResponse : IBaseResponse
    {
        [ProtoMember(1, IsRequired = true)]
        public required bool Success { get; set; }
    }
}