using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HackerRank
{
    class Program
    {
        
        enum dow { sun,mon,tue}
        static void Main(string[] args)
        {
            //string a = " Hi Hello How Are YOu";
            //Program p = new Program();
            //Program.StringReverse(a);
            //p.ListMethod();
            //Console.WriteLine("Hello");
            //Console.WriteLine("Varathan");
            //string c = Console.ReadLine();
            //Console.Write(c);
            //Program.ReverseString("Hello");
            //Program.chkPalindrome("Hello");
            //string a = "VarathanS";
            //Console.WriteLine(a[3]);
            //Console.WriteLine(a.Length / 2);

            //Console.WriteLine(((object)10).Equals(10));
            //Program program = new Program();
           // program.NoOfOccurrence3("aaaabbbccc");

           // var result = program.DynamicVAR("AAA");
           // Console.WriteLine(result);
           // oops op = new oops(){ID=101, FN="Varathan",SN="Suyambu"};
           // var obj = new oops() { ID = 101, FN = "Varathan", SN = "Suyambu" };
           // ((IA)obj).print();
           // ((IB)obj).print();
            //((AC)obj).printNormal();
            //((AC)obj).printAbstract();
           // ((AC)obj).print();
           // GuidIdentifier guidIdentifier = new GuidIdentifier();
            //guidIdentifier.printGuid(10);
           // MyGenericClass<int> myGenericClass = new MyGenericClass<int>(10);
            //myGenericClass.genericMethod(20);
           // GenericMethodClass genericMethodClass = new GenericMethodClass();
          
           // StaticEx.print();
           // Console.WriteLine((int)dow.sun);
           // Employee[] employeeArray=new Employee[5];
           // employeeArray[0] = new Employee() { Name="Varathan",ID=12,Age=23};
           // Program p = new Program();
           // p.NoOfOccurrence5(new int[] { 4,50,1,1, 2, 2, 3, 3, 3, 4, 4, 4,4});
            //Console.WriteLine(Math.Round(6.5));
            //Console.WriteLine(Math.Round(11.5));
            //string str = "aVasdasdasda";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    StringBuilder subString = new StringBuilder(str.Length - i);
            //    for (int j = i; j < str.Length; j++)
            //    {
            //        subString.Append(str[j]);
            //        Console.Write(subString + " ");
            //    }
            //}  
            //Program p = new Program();
            //p.findingSubString("123456789zxczxc123456789", "zxczxc");
            int[] arrayint = {1,3,4,5,6,8,10,15 };
            foreach (int data in arrayint) {
                Console.WriteLine(data);
            }
        }
        public static string StringReverse(string a)
        {
            string[] b = a.Split(' ');
            Array.Reverse(b);
            string c = string.Join("-", b);
            return c;
        }
        public void ListMethod()
        {
            List<int> list = new List<int>() { 1, 1, 1, 1, 1, 2, 5, 7 };
            Console.WriteLine(list.ElementAt(6));
        }
        internal static void ReverseString(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
        internal static void chkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");
        }
        public void NoOfOccurrence(string sample)
        {

            var dictionary = sample.GroupBy(c => c).Select(c => new { Char = c.Key, Count = c.Count() });

            foreach (var data in dictionary)
            {
                Console.WriteLine(data.Char + " = " + data.Count.ToString());
            }
        }
        public void NoOfOccurrence2(string sample)
        {

            var dictionary = sample.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());

            foreach (var data in dictionary)
            {
                Console.WriteLine(data.Key + " = " + data.Value.ToString());
            }
        }
        public void NoOfOccurrence3(string input)
        {
           
            while (input.Length > 0)
            {
                Console.Write(input[0] + " : ");
                int count = 0; 
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[0] == input[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(),null);
                Console.WriteLine("Length Now : " + input.Length);
            }
            Console.ReadLine();
        }
        public void NoOfOccurrence4(int[] input)
        {

            var result = input.GroupBy(x => x).Select(c => new { a=c.Key ,b=c.Count()});
            foreach (var item in result)
            {
                Console.WriteLine("Key : " + item.a + " " + "No Of Occurence : " + item.b);
            }
        }
        public void NoOfOccurrence5(int[] input)
        {
            var result = new SortedList<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (result.ContainsKey(input[i])) { continue; }
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                    }
                    
                }
  
                result.Add(input[i], count);
                //Console.WriteLine("{0} is occured {1} times",input[i],count);
            }
            foreach (var item in result)
            {
                Console.WriteLine("{0} is occured {1} times",item.Key,item.Value);
            }
        }

        public dynamic DynamicVAR(string input)
        {
            var Astring = input;
            Console.WriteLine(Astring.GetType());
            dynamic Bstring;
            Bstring =input;
            Console.WriteLine(Bstring.GetType());
            Bstring = 100;
            Console.WriteLine(Bstring.GetType());
            return Bstring;
        }
        void findingSubString(string mainString,string subString) {
            int i = 0; int j = 0; int flag = 0; int cycle = 0;
            while(i<subString.Length)
            {
                cycle++;
                Console.WriteLine(cycle);
                if (subString[i] == mainString[j])
                {
                    flag++;
                    if (flag == subString.Length)
                    { Console.WriteLine("Start Position {0} End Position {1}",j-subString.Length+1, j); break; }
                    i++;
                    j++;
                   
                }
                else {
                    j = j + 1 - flag;
                    i = 0;
                    flag = 0;
                  
                }
            }
        }
    }
}
