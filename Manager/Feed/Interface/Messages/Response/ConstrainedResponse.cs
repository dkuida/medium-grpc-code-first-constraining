using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages
{
    [ProtoContract]
    public class ConstrainedResponse
    {
        [ProtoMember(1, IsRequired = true)]
        public required bool Success { get; set; }
        
        [ProtoMember(2, IsRequired = true)]
        public required string Message { get; set; }
    }
}