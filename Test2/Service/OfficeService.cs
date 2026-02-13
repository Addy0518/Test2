using Test2.Interface;

namespace Test2.Service
{
    public class OfficeService: IOfficeService
    {
        private readonly IOfficeRepositry _officeRepositry;

        public OfficeService(IOfficeRepositry officeRepositry)
        {
            _officeRepositry = officeRepositry;
        }
        public async Task<string> CreateOffice(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) throw new Exception("禁止為空");

            return await _officeRepositry.CreateOffice(json);

        }
    }
}
