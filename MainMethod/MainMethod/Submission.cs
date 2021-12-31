using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Submission
    {
        //Add method
        public static int AddNumber(int userNum)
        {
            int newNum = userNum + 10;
            return newNum;

        }

        //Subtraction method
        public static int addNumber(decimal userNum)
        {
            decimal newNum2 = userNum - 10;
            return (int)newNum2;
        }

        //Multiply method
        public static int AddNumber(string userNum)
        {

            int newNum3 = Convert.ToInt32(userNum) + 2;
            return newNum3;
        }
    }
}
