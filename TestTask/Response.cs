using System;
using TestTask.Interfaces;

namespace TestTask
{
    public class Response : IResponse
    {
        public int StatusCode { get; }
        public string ResponseBody { get; }

        public Response(int statusCode, string responseBody)
        {
            throw new NotImplementedException();
        }
    }
}