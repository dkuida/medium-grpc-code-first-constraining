using ProtoBuf;

namespace Medium.Manager.Feed.Interface.Messages.Official
{
    [ProtoContract]

    public class InheritingRequest : BaseRequest
    {
        [ProtoMember(3, IsRequired = true)]
        public required string CustomProperty { get; set; }
    }
}