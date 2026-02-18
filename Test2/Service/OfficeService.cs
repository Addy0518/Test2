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

        public async Task<string> GetOffice(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) throw new Exception("禁止為空");

            return await _officeRepositry.GetOffice(json);

        }

        public async Task<string> GetAllOffice()
        {
        
            return await _officeRepositry.GetAllOffice();

        }


        public async Task<string> CreateOffice(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) throw new Exception("禁止為空");

            return await _officeRepositry.CreateOffice(json);

        }

        public async Task<bool> UpdateOffice(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) throw new Exception("禁止為空");

            return await _officeRepositry.UpdateOffice(json);

        }

        public async Task<bool> DeleteOffice(string json)
        {
            if (string.IsNullOrWhiteSpace(json)) throw new Exception("禁止為空");

            return await _officeRepositry.DeleteOffice(json);

        }
    }
}
