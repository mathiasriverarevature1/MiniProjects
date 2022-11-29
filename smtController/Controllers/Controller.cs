using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using smtBusiness;
using smtModels;

namespace smtController.Controllers
{
    public class Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class smtController : ControllerBase
        {
            private readonly IBusinessLayer _businessLayer;
            public smtController(IBusinessLayer ibl)
            {
                this._businessLayer = ibl;
            }


            //select a company by Ticker
            [HttpPost("get-company")]
            public async Task<ActionResult<Stocks?>> GetCompanyByTickerAsync(GetCompanyDto ticker)
            {
                Stocks? retrievedStock = await this._businessLayer.GetCompanyByTickerAsync(ticker);

                if (retrievedStock == null)
                {
                    return NotFound(new { userNotFound = ticker });
                }

                return Ok(retrievedStock);
            }

            //select all company
            [HttpGet("get-all-companies")]
            public async Task<ActionResult<List<Stocks?>>> GetAllCompaniesAsync()
            {
                List<Stocks?> retrievedCompanies = await this._businessLayer.GetAllCompaniesAsync();

                //if (retrievedCompanies == null)
                //{
                //    return BadRequest(retrievedCompanies);
                //}

                return (retrievedCompanies);
            }

            //Update company
            [HttpPut("update-companies")]
            public async Task<ActionResult<Stocks?>> UpdateCompanyAsync(updateDto update)
            {
                Stocks? updatedCompany = await this._businessLayer.UpdateCompanyAsync(update);

                //if (updatedCompany == null)
                //{
                //    return BadRequestObjectResult(updatedCompany);
                //}

                return (updatedCompany);
            }

            //select company by price per stock
            [HttpPost("get-companies-by-price")]
            public async Task<ActionResult<List<Stocks?>>> GetCompanyByPriceAsync(GetCompanyByPriceDto price)
            {
                List<Stocks?> retrievedStock = await this._businessLayer.GetCompanyByPriceAsync(price);

                //if (retrievedStock == null)
                //{
                //    return NotFound(new { userNotFound = ticker });
                //}

                return Ok(retrievedStock);
            }

            //buy stock endpoint

        }

    }
}
