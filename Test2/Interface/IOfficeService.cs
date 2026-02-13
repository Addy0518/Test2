namespace Test2.Interface
{
    public interface IOfficeService
    {
        Task<string> CreateOffice(string json);
    }
}
