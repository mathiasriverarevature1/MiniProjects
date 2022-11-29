using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smtModels;

namespace smtRepository
{
    public class RepoLayer
    {
        //"Server=tcp:mathiasserverminiprojects.database.windows.net,1433;Initial Catalog=mathiasriveraSMT;Persist Security Info=False;User ID=mathias;Password=password123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public async Task<List<Stocks?>> GetAllCompaniesAsync()
        {

        }
        public async Task<List<Stocks?>> GetCompanyByPriceAsync(GetCompanyByPriceDto price)
        {

        }
        public async Task<Stocks?> GetCompanyByTickerAsync(GetCompanyDto ticker)
        {

            SqlConnection conn = new SqlConnection("Server=tcp:mathiasserverminiprojects.database.windows.net,1433;Initial Catalog=mathiasriveraSMT;Persist Security Info=False;User ID=mathias;Password=password123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            using (SqlCommand command = new SqlCommand($"SELECT FROM Stocks WHERE Ticker = @ticker", conn))
            {
                command.Parameters.AddWithValue("@ticker", ticker); //SQL inj prevention
                conn.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                while (ret.Read())
                {
                    Stocks s = new Stocks((Guid)ret[0], (Guid)ret[1], ret.GetString(2), ret.GetDecimal(3), ret.GetInt32(4));
                }
                conn.Close();
                return s;
            }

        }
        public async Task<Stocks?> UpdateCompanyAsync(updateDto update)
        {

        }







    }
}
