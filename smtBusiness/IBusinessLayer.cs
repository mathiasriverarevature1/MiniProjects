using smtModels;

namespace smtBusiness
{
    public interface IBusinessLayer
    {
        Task<List<Stocks?>> GetAllCompaniesAsync();
        Task<Stocks?> GetCompanyByPriceAsync(GetCompanyByPriceDto price);
        Task<Stocks?> GetCompanyByTickerAsync(GetCompanyDto ticker);
        Task<Stocks?> UpdateCompanyAsync(updateDto update);
    }
}