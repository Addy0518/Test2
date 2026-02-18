namespace Test2.Interface
{
    public interface IOfficeService
    {

        Task<string> GetOffice(string json);

        Task<string> GetAllOffice();

        Task<string> CreateOffice(string json);

        Task<bool> UpdateOffice(string json);

        Task<bool> DeleteOffice(string json);
    }
}
