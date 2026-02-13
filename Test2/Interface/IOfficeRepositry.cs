namespace Test2.Interface
{
    public interface IOfficeRepositry
    {
        Task<string> CreateOffice(string json);
    }
}
