namespace Medium.Manager.Feed.Interface.Messages
{
    internal interface IOtherProperty
    {
        string OtherProperty { get; set; }
    }

    internal interface IOtherRequest : IBaseRequest, IOtherProperty;
}