using System.Diagnostics.CodeAnalysis;
using ProtoBuf;
using ProtoBuf.Meta;

namespace Medium.iFX.Utilities
{

    [ProtoContract]
    // [ProtoInclude(100, typeof(ResponseWrapper<>))]
    public class ResponseWrapper
    {

        [ProtoMember(1, IsRequired = true)]
        public List<Error> Errors
        { get; set; }

        public bool HasErrors => Errors.Count > 0;

        public ResponseWrapper(IEnumerable<Error> errors)
        {
            Errors = errors.Distinct().ToList();
        }

        public ResponseWrapper()
        {
            Errors = [];
        }

        public ResponseWrapper(Error error)
        {
            Errors = [error];
        }

        public static ResponseWrapper Empty
        {
            get
            {
                Error[] errors = Array.Empty<Error>();
                ResponseWrapper responseWrapper = new(errors);
                return responseWrapper;
            }
        }

        public static ResponseWrapper From(Exception exception)
        {
            Error error = new(exception);
            Error[] errors = { error };
            ResponseWrapper? responseWrapper = new(errors);
            return responseWrapper;
        }

        public static ResponseWrapper From(Error error)
        {
            Error[] errors = { error };
            ResponseWrapper? responseWrapper = new(errors);
            return responseWrapper;
        }

        public static ResponseWrapper From(List<Error> errors)
        {
            return new ResponseWrapper(errors);
        }
    }

    [ProtoContract]
    public class ResponseWrapper<TR> : ResponseWrapper
    where TR : class
    {
        [ProtoMember(2)]
        public TR? Response
        { get; set; }

        public ResponseWrapper(): base()
        {

        }

        public ResponseWrapper(TR? response, IEnumerable<Error> errors) : base(errors)
        {
            Response = response;
        }

        public ResponseWrapper(IEnumerable<Error> errors) : base(errors)
        {
        }

        [SuppressMessage("Layout", "IDESIGN103:Avoid compound statements.")]
        public ResponseWrapper(TR? response) : base(Array.Empty<Error>())
        {
            Response = response;
        }

        public static ResponseWrapper<TR> From(TR? response, IEnumerable<Error> errors)
        {
            ResponseWrapper<TR> responseWrapper = new(response, errors);

            return responseWrapper;
        }

        public static ResponseWrapper<TR> From(IEnumerable<Error> errors)
        {
            ResponseWrapper<TR> responseWrapper = new(errors);

            return responseWrapper;
        }

        public static ResponseWrapper<TR> From(TR? response)
        {
            ResponseWrapper<TR> responseWrapper = new(response);

            return responseWrapper;
        }
        
        public static new ResponseWrapper<TR> From(Exception exception)
        {
            Error error = new(exception);
            Error[] errors = new Error[] { error };
            ResponseWrapper<TR> responseWrapper = new (errors);

            return responseWrapper;
        }
    }
}
