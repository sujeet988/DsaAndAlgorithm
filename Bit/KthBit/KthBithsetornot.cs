using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthBit
{
    internal class KthBithsetornot
    {
        //if last bit is 1 then its setbit else its not set bity
        public static Boolean IsSetBit(int n)
        {
            if ((n & 1) != 0)
            {
                return true; 
            }
            return false;

        }
        public static Boolean IsKthSetBitusingleftshift(int n,int k)
        {
            /*
          n=5 (00..0101)
          k=3-1=2 //shift right by 2 the x value would be 4
          x=4(00 ...0100)
            then and opertaor
            00 ---0101
            00 ---0100
            &
            -----------
            00 ---0100 --3rd bit is 1 so answer is 1

          */
            int x = (1 << (k - 1)); //n/2 power k-1
            if ((n & x) != 0)//here logic for check kth bit
            {
                return true;
            }
            return false;

        }

        public static Boolean IsKthSetBitusingrightshift(int n, int k)
        {
            /*
             n=5 (00..0101)
             k=3-1=2 //shift right by 2 the x value would be 1
             x=1(00 ...0001)
             then and opertaor
            00 ---0101
            00 ---0001
            &
            -----------
            00 ---0001 --3rd bit is 1 so answer is 1
            
             */

            int x = (n >> (k - 1)); //n/2 power k-1
            if ((x & 1) != 0) //checking logic  for last bit
            {
                return true;
            }
            return false;

        }

        public static int countofsetbit(int n)
        {
            return 1;
        }
    }
}
