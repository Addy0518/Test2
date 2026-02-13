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

        public async Task<string> CreateOffice(string json)
        {
            using var con = new SqlConnection(_connectionString);

            var pram=new DynamicParameters();
            pram.Add("@InBox_Json", json);

            return await con.QueryFirstOrDefaultAsync<string>(
                "usp_ACPD_Create", 
                pram, 
                commandType: System.Data.CommandType.StoredProcedure
                );
        }
    }
}
