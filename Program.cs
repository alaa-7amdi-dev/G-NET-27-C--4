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

        }
    }
}
