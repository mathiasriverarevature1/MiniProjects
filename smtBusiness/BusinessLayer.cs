using smtModels;
using smtRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static smtBusiness.BusinessLayer;

namespace smtBusiness
{
    public class BusinessLayer
    {

        public class smtBusinessLayer : IBusinessLayer
        {
            private readonly IRepoLayer _repoLayer;
            public smtBusinessLayer(IRepoLayer irl)
            {
                _repoLayer = irl;
            }

            public async Task<Stocks?> GetCompanyByTickerAsync(GetCompanyDto ticker)
            {
                Stocks? retrievedCompany = await this._repoLayer.GetCompanyByTickerAsync(ticker);
                if (retrievedCompany != null)
                {
                    return (retrievedCompany);
                }
                else return null;
            }

            public async Task<List<Stocks?>> GetAllCompaniesAsync()
            {
                List<Stocks?> allCompanies = await this._repoLayer.GetAllCompaniesAsync();
                return allCompanies;

            }
            public async Task<List<Stocks?>> GetCompanyByPriceAsync(GetCompanyByPriceDto price)
            {
                List<Stocks?> stocks = await this._repoLayer.GetCompanyByPriceAsync(price);
                return stocks;
            }
            public async Task<Stocks?> UpdateCompanyAsync(updateDto update)
            {
                Stocks? updatedStock = await this._repoLayer.UpdateCompanyAsync(update);
                return updatedStock;
            }


        }
    }

    
}