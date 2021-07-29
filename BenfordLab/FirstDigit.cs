﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenfordLab
{
    public class FirstDigit
    {
        /* Given an integer X, this method returns the first digit
         * 
         * For example,
         *   5 ==> returns 5
         *   10 ==> returns 1
         *   654321 ==> returns 6
         */
        public static int getFirstDigit(int digit) {
            // TODO
            f_digit = Math.Abs(digit);
           if (f_digit >= 10)
               f_digit /= 10;
            return f_digit;
            
        }    
    }
}
