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
        public static string AddNumber(string userNum)
        {
            int userNum4 = Convert.ToInt32(userNum);
            int newNum3 = userNum4 + 2;
            return newNum3;
        }
    }
}
