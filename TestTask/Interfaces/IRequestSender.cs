namespace TestTask.Interfaces
{
    interface IRequestSender
    {
        Request SendRequest(string requestType, string requestBody);
    }
}