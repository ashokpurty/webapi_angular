using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessService;

namespace RestfulWebApi.Controllers
{
    public class CalculatorController : ApiController
    {
        private ICalculator _calculator;

        /// <summary>
        /// CalculatorController
        /// </summary>
        /// <param name="calculator"></param>
        public CalculatorController(Calculator calculator)
        {
            _calculator = calculator;
        }
        /// <summary>
        /// GenerateReferenceNumber
        /// </summary>
        /// <param name="data">data</param>
        /// <returns>Reference Number</returns>
        [HttpGet]
        public string Get(string data)
        {
            return _calculator.GenerateReferenceNumber(data);
        }
    }
}
