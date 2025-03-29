using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages
{
    [ProtoContract]
    public class ConstrainedRequest
    {
        [ProtoMember(1, IsRequired = true)]
        public required string RequestId { get; set; }
        
        // Add additional properties as needed
    }
}