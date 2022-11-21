using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smtModels
{
    public class GetCompanyDto
    {
        public GetCompanyDto(string ticker)
        {
            Ticker = ticker;
        }

        public string Ticker { get; set; }    
    }
}
