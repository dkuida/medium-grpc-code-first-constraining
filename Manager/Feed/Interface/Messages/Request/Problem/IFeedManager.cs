using Medium.iFX.Utilities;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Configuration;

namespace Medium.Manager.Feed.Interface.Messages.Problem
{
    [Service]
    public interface IFeedManager
    {
        [Operation]
        ValueTask<BaseResponse> Base(BaseRequest request, CallContext context = default);

        [Operation]
        ValueTask<OtherResponse> Inheriting(OtherRequest request, CallContext context = default);

        [Operation]
        ValueTask<OtherResponse> InheritingMore(InheritingRequest request, CallContext context = default);

        [Operation]
        ValueTask<ResponseWrapper<OtherResponse>> Wrapper(InheritingRequest request, CallContext context = default);

        [Operation]
        ValueTask<ResponseWrapper<InheritingResponse>> OtherWrapper(InheritingRequest request, CallContext context = default);

        [Operation]
        ValueTask<ResponseWrapper> EmptyWrapper(InheritingRequest request, CallContext context = default);
    }
}