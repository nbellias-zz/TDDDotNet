using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibraryForTDD
{
    public class Class1
    {
    }

    public class Rooter
    {
        public Rooter()
        {
        }

        public double SquareRoot(double input)
        {
            // Initial code
            // throw new NotImplementedException();
            // Another try
            // return input / 2;
            // Final try
            if (input <= 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }
            double result = input;
            double previousResult = -input;
            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                // Refactoring
                result = (result + input / result) / 2;
                //was: result = result - (result * result - input) / (2*result);
            }
            return result;
        }
    }
}
