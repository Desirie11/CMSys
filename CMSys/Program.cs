using System;
using System.Collections.Generic;
using System.Linq;
using ApplicationLib;

namespace CMSys
{
    public class Program
    {
        public static void Main(String[]args)
        {
            {
                Console.WriteLine("Login Type please select an option\n");
                Console.WriteLine("1.User" +
                                  "\n2.Admin" +
                                  "\n3.Branch\n");

                Console.WriteLine("---------------------------------");
                Console.WriteLine("Input an Option: ");
                String Option = Console.ReadLine();
                int num = Int32.Parse(Option);

                if (num == 1)
                {

                    AppValidation.validator1();
                }
                if (num == 2)

                {

                    AppValidation.Validator2();

                }

                if (num == 3)

                {
                    AppValidation.validator3();
                }

                Console.ReadKey();

            }
        }

        
    }
}