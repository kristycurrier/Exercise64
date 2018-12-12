using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise64
{
    public class Validator
    {
        public static bool IsInt(string input)
        {
            int num;
            bool validInt = true;
            try
            {
                num = int.Parse(input);
            }
            catch
            {
                validInt = false;
            }
            return validInt;
        }
    }
}
