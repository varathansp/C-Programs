using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            //obj.pattern1(5);
            obj.pattern3(7);
            telephone telephoneObj = new telephone();
            telephoneObj.answer();
            telephone.HangUp();
            string a = "aaa";
            string b= a.stringConCatHelperMethod("bbb");
            Console.WriteLine(a.stringConCatHelperMethod("bbb"));
            CustomStringAttribute cus = new CustomStringAttribute();
            obj.attri(cus);

        }
        [CustomString(string1 = "aaa", string2 = "bbb")]
        public void attri(CustomStringAttribute cs)
        {           
        }
        public void pattern1(int rows)
        {
            for (int row = rows; row >= 0; row--)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
        public void pattern2(int rows)
        {
            for (int row = 0; row <= rows; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
        public void pattern3(int rows)
        {
            int Spaceflag = rows;
            for (int row = 1; row <= rows; row++)
            {
                for (int i = 1; i < Spaceflag; i++)
                {
                    Console.Write(" ");
                }
                Spaceflag--;
                for (int j = 1; j <= 2 * row - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Spaceflag = 1;

            for (int row = 1; row <= rows - 1; row++)
            {
                for (int i = 1; i <= Spaceflag; i++)
                {
                    Console.Write(" ");
                }
                Spaceflag++;
                for (int j = 1; j <= 2 * (rows - row) - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

    }
    public class telephone
    {
        public void answer()
        {
            Console.WriteLine("phone answered.");
        }
        public static void HangUp()
        {
            Console.WriteLine("phone hung up.");
        }
    }

}
