using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        //   Prime Number
        //   The Number which divide by itself only.

        static void Main(string[] args)
        {
            int n = 7;

            for (int i = 2; i <=n; i++)
            {
                if (n%i==0)
                {
                    Console.WriteLine(" This is Prime Number");
                    break;
                }
            }
            Console.ReadLine();
        }
    }


