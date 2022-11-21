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

            }

            public async Task<List<Stocks?>> GetAllCompaniesAsync()
            {

            }
            public async Task<Stocks?> GetCompanyByPriceAsync(GetCompanyByPriceDto price)
            {

            }
            public async Task<Stocks?> UpdateCompanyAsync(updateDto update)
            {

            }


        }
    }

    
}