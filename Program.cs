using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
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
            #region Q3
            //string fileExtention = ".pdf";
            //string fileType;
            //switch (fileExtention)
            //{
            //    case ".pdf":
            //        fileType = "pdf Document";
            //        break;
            //    case ".doc":
            //    case ".docx":
            //        fileType = "word Document";
            //        break;
            //    case ".xisx":
            //    case ".xis":
            //        fileType = "Excel spardSheet";
            //        break;
            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Iamge file";
            //        break;

            //    default:
            //        fileType = "Unknown file";
            //        break;
            //}
            //Console.WriteLine(fileType);
            /////////////////////////////////////////
            //string fileExtention = ".pdf";
            //string fileType = fileExtention switch
            //{ 
            //     ".pdf"=> "pdf Document",
            //    ".doc" or ".docx"=> "word Document",
            //    ".xisx" or ".xis" => "Excel spardSheet",
            //    ".jpg" or ".png" or ".gif" => "Iamge file",
            //    _=> "Unknown file"
            //};
            //Console.WriteLine(fileType);


            #endregion
            #region Q4
            //int temperature = 35;
            //String waterAdvice = temperature < 0 ? "Frezzing! stay indoors" : temperature < 15 ? "Cold Wear a jacket" :
            //    temperature < 25 ? "pleasant weather" : temperature < 35 ? "Warm stay hydrated" : "Hot! avoid sun exposure";
            //Console.WriteLine(waterAdvice);
            //(b)
            /// No,it's abbreviation of the code. =>If there's a hidden condition, it's preferable to use `if elseif
            ///  makes it more readable. If it's a simple condition, we can use the ternart operator. 
            #endregion
            #region Q5
            int i = 0;
            do 
            {
                i++;
                Console.Write("Enter password: ");
                string password = Console.ReadLine();
                bool hasMinLength = password.Length >= 8;
                bool hasUpper = false;
                bool hasDigit = false;
                bool hasSpace = false;
                foreach (char c in password)
                {
                    if (char.IsUpper(c))
                        hasUpper = true;

                    if (char.IsDigit(c))
                        hasDigit = true;

                    if (c == ' ')
                        hasSpace = true;
                }
                if (hasMinLength && hasUpper && hasDigit && !hasSpace)
                {
                    Console.WriteLine("Password accepted!");
                }
                else
                {
                  
                    Console.WriteLine("Invalid password! Violations:");
                    if (!hasMinLength)
                        Console.WriteLine("password must be at least 8 characters");
                    if (!hasUpper)
                        Console.WriteLine("password must contain at least one uppercase letter");

                    if (!hasDigit)
                        Console.WriteLine("password must contain at least one digit");

                    if (hasSpace)
                        Console.WriteLine("password must not contain spaces");
                }


            } while (i<5);
           if(i==5)
                Console.WriteLine("Account Locked");

            

            #endregion
        }
    }
}
