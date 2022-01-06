using System;
using System.Collections.Generic;
using System.Text;
using TestTask.Interfaces;

namespace TestTask
{
    class Request : IRequest
    {
        public string RequestType { get; }
        public string RequestBody { get; }

        public Request(string requestType, string requestBody)
        {
            throw new NotImplementedException();
        }
    }
}
