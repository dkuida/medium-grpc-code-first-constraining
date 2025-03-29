using Medium.Manager.Feed.Interface.Messages.Constraint;

namespace Medium.Manager.Feed.Interface.Messages
{
    internal interface IInheritingResponse : IBaseResponse
    {
        public  string Message { get; set; }
    }
}