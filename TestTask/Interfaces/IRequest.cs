namespace TestTask.Interfaces
{
    interface IRequest
    {
        string RequestType { get; }
        string RequestBody { get; }
    }
}