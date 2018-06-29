using System.Net;

namespace Vision2.Api.Model {
    public interface IVision2Response {
        string RequestValue { get; set; }
        string JsonResponse { get; set; }
        HttpStatusCode StatusCode { get; set; }
        string ErrorMessage { get; set; }
    }
    public interface IVision2Response<T> : IVision2Response {
        T Data { get; set; }
    }

    public class Vision2Response : IVision2Response {
        public string RequestValue { get; set; }

        public string JsonResponse { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class Vision2Response<T> : Vision2Response, IVision2Response<T> where T : new() {
        public T Data { get; set; }
    }
}
