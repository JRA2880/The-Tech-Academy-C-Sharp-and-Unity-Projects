using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParametersApp
{
    class Calculate
    { 
        public int Function(int input1, int input2 = 1)
        {
            int result = (input1 * input1 / input1) * input2;
            return result;
        }
    }
}
