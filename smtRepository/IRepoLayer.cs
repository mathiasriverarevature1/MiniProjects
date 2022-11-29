using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smtModels;

namespace smtRepository
{
    public interface IRepoLayer
    {
        Task<List<Stocks?>> GetAllCompaniesAsync();
        Task<List<Stocks?>> GetCompanyByPriceAsync(GetCompanyByPriceDto price);
        Task<Stocks?> GetCompanyByTickerAsync(GetCompanyDto ticker);
        Task<Stocks?> UpdateCompanyAsync(updateDto update);
    }
}
