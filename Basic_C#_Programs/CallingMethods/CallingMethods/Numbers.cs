using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Numbers
    {
        //Add method
        public static int AddNumber(int userNum)
        {
            int newNum = userNum + 10;
            return newNum;
            
         }

        //Subtraction method
        public static int SubNumber(int userNum)
        {
            int newNum2 = userNum- 10;
            return newNum2;
        }

        //Multiply method
        public static int MultiplyNumber(int userNum)
        {
            int newNum3 = userNum * 2;
            return newNum3;
        }


    }

}
