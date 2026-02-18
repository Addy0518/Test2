using Dapper;
using Microsoft.Data.SqlClient;
using Test2.Interface;

namespace Test2.Repositry
{
    public class OfficeRepositry: IOfficeRepositry
    {
        private readonly string _connectionString;

        public OfficeRepositry(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        //因為CRUD統一使用SQL的預存程序執行,所以這裡的代碼實際上都只是呼叫預存程序,我們就把它寫成一個共用方法就好
        private async Task<string> ExecuteJsonAsync(string ExName, string? json=null)
        {
            using var con = new SqlConnection(_connectionString);
            var pram = new DynamicParameters();
            pram.Add("@InBox_Json", json);

            return await con.QueryFirstOrDefaultAsync<string>(
              ExName,
              pram,
              commandType: System.Data.CommandType.StoredProcedure
              ) ?? "[]";
        }

        public async Task<string> GetOffice(string json)
        {
            return await ExecuteJsonAsync("usp_ACPD_ViewOne", json);
        }

        public async Task<string> GetAllOffice()
        {
            return await ExecuteJsonAsync("usp_ACPD_ViewAll");
        }


        public async Task<string> CreateOffice(string json)
        {
            return await ExecuteJsonAsync("usp_ACPD_Create", json);
        }


        public async Task<bool> UpdateOffice(string json)
        {
            var result=await ExecuteJsonAsync("usp_ACPD_Update", json);
            return result.Contains("Success");
        }


        public async Task<bool> DeleteOffice(string json)
        {
            var result = await ExecuteJsonAsync("usp_ACPD_Delete", json);
            return result.Contains("Success");
        }
    }
}
