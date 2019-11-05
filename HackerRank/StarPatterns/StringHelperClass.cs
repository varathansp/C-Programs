using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarPatterns
{
    public static class StringHelperClass
    {
        public static string stringConCatHelperMethod(this string input1,string input2)
        {
            return input1+input2;
        }
    }
    public class CustomStringAttribute : Attribute
    {
        public string string1 { get; set; }
        public string string2 { get; set; }
       
    }
}
