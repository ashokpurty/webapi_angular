using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService
{

    /// <summary>
    /// Calculator
    /// </summary>
    public class Calculator : ICalculator
    {
        private const string weigth = "731";
        private const int controlNumberCalculator = 10;
        /// <summary>
        /// GenerateReferenceNumber
        /// </summary>
        /// <param name="input">input</param>
        /// <returns>ReferenceNumber</returns>
        public string GenerateReferenceNumber(string input)
        {
            int result = 0;
            int sum = 0;
            int innerCount = 0;
            int length = input.Length;
            for (int count = input.Length-1; 0 <= count; count--)
            {
                if (innerCount == 3)
                {
                    innerCount = 0;
                }

                sum += (int)Char.GetNumericValue(input[count]) * (int)Char.GetNumericValue(weigth[innerCount]);
                innerCount++;
            }

            int decade = sum % 10;
            if (decade != 0)
                result = controlNumberCalculator - decade;
            return result.ToString();
        }
    }
}
