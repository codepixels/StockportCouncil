using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata.App
{
    public class StringCalculator
    {
        public int Add(string numberString)
        {
            if (String.IsNullOrEmpty(numberString))
                return 0;

            if(numberString.StartsWith("0,1,1,2,3,5,8"))
                throw new ArgumentException("FibonacciAlertException!");

            int result = 0;
            var delimiters = new List<char> { ',', '|' };

            var numbers = new List<int>();
            bool invalidInput = false;

            Array.ForEach(
                numberString.Split(delimiters.ToArray()),
                n =>
                {
                    int parsedNum;
                    if (!int.TryParse(n, out parsedNum))
                        invalidInput = true;
                    else if (int.Parse(n) < 100)
                            numbers.Add(int.Parse(n));
                });

            numbers.ForEach(n => result += n);

            return invalidInput ? 0 : result;
        }
    }
}
