﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNo;
            Console.Write("Enter the Number : ");
            iNo = Convert.ToInt32(Console.ReadLine());

            CountOccurs co = new CountOccurs(iNo);
            co.Count0();
            co.display();

        }
    }
}
