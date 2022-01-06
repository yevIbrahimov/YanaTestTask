namespace TestTask.Interfaces
{
    interface IResponse
    {
        int StatusCode { get; }
        string ResponseBody { get; }
    }
}