using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //(A)=>Because the string is immutable and every iteration modifies the content and Create new pointer to new content in addition to old content
            //,Old content Become Unreachable,These processes lead to memory consumption
            //(B)=>
            //StringBuilder productList = new StringBuilder();
            //for (int i = 0; i < 5000; i++)
            //{
            //    productList.Append( "PROD" + i + ",");
            //}
            //string Result=productList.ToString();
            //Console.WriteLine(Result);
            //(C)=>
            //var Watch0 = Stopwatch.StartNew();
            //string productList1 = "";
            //for (int i = 0; i <=5000; i++)
            //{
            //    productList1 += "PROD" + i + ",";
            //}
            //Watch0.Stop();
            //Console.WriteLine(Watch0.ElapsedMilliseconds);
            //var Watch2 = Stopwatch.StartNew();
            //StringBuilder productList2=new StringBuilder();
            //for (int i = 0; i <=5000; i++)
            //{
            //    productList2.Append("PROD" + i + ",");
            //}
            //Watch2.Stop();
            //Console.WriteLine(Watch2.ElapsedMilliseconds);
            #endregion
            #region Q2
            //Console.WriteLine("Enter Your Age :");
            //int.TryParse(Console.ReadLine(), out int age);
            //Console.WriteLine("Enter Day :");
            //int day = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" Are you Student? Enter true/false");
            //bool isStudent = Console.ReadLine().ToLower() == "true";
            //double price = 0;
            //if (age <= 5)
            //    price = 0;
            //else if (age <= 12)
            //    price = 30;
            //else if (age <= 59)
            //    price = 50;
            //else
            //    price = 25;

            //if (day == 7 && day == 6)
            //    price += 10;
            //if (isStudent && price > 0)
            //    price *= 0.2;

            //Console.WriteLine($"Final price Equal {price}");
            #endregion

        }
    }
}
