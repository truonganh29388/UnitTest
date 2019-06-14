using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest1.Models
{
    public class StringOperator
    {
        public string Concate(string str1, string str2)
        {
            return str1 + str2;
        }

        public bool StartWith(string start, string strTest)
        {
            return strTest.StartsWith(start);
        }
    }
}
