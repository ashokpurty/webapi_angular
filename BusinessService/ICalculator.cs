using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{
    /// <summary>
    /// ICalculator
    /// </summary>
    public interface ICalculator
    {
        string GenerateReferenceNumber(string input);
    }
}
