using System;

namespace TestTask
{
    enum RequestTypes
    {
        Get,
        Put,
        Delete
    }

    class RequestSender
    {
        public Request SendRequest(string requestType, string requestBody)
        {
            throw new NotImplementedException();
        }
    }
}
