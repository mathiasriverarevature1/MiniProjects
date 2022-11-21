using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using smtBusiness;
using smtModels;

namespace smtController.Controllers
{
    public class Controller
    {

        public class smtController : ControllerBase
        {
            private readonly IController _businessLayer;
            public smtController(IBusinessLayer ibl)
            {
                this._businessLayer = ibl;
            }
        }
        //select all company

        //select a company by Ticker
        [HttpPost("get-company")]
        public async Task<ActionResult<Stocks?>> GetCompanyByTickerAsync(GetCompanyDto ticker)
        {
            Stocks? retrievedStock = await this._businessLayer.GetCompanyByTickerAsync(ticker);

            if (retrivedStock == null)
            {
                return NotFound(new { userNotFound = ticker });
            }

            return Ok(retrievedStock);
        }

        //select company by price per stock
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

        //select company by price per stock
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

        //buy stock endpoint


    }
}
