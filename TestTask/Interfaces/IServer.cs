namespace TestTask.Interfaces
{
    interface IServer
    {
        Response GetResponse(); //get all cars
        Response PutResponse(); //add new car
        Response DeleteResponse(); //delete car
    }
}