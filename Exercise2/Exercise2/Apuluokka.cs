using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    static class Apuluokka
    {
        public static void Pause()
        {
            Console.Write("\nPress enter to continue...");
            Console.ReadLine();
        }

        public static void InsertLineSepatator()
        {
            Console.Write("\n----------------------------\n");
 
        }

        public static void InsertWideLineSepatator()
        {
            Console.Write("\n\n----------------------------\n\n");

        }

        public static void InsertLines(int amount)
        {
            for(int i=0;i<amount;i++)
                Console.WriteLine();
        }

        public static void printBMIresult(double BMI)
        {
            int codeValue;

            if (BMI < Constants.MyConstantsClass.MyTwoZero)
            {
                Console.WriteLine("You are too slim, eat some more.");
                codeValue=11;
            }

            else if (BMI <= Constants.MyConstantsClass.MyTwoZero && BMI <= Constants.MyConstantsClass.MyTwoFive)
            {
                Console.WriteLine("You have a perfect weight.");
                codeValue=12;
            }

            else if (BMI <= Constants.MyConstantsClass.MyTwoFive && BMI <= Constants.MyConstantsClass.MyThreeZero)
            {
                Console.WriteLine("You are overweight.");
                codeValue = 13;
            }

            else
            {
                Console.WriteLine("You are grossly overweight!");
                codeValue = 14;
            }

            switch (codeValue)
            {
                case 11:
                    Console.WriteLine("Koodi on : {0}",codeValue);
                    break;

                case 12:
                    Console.WriteLine("Koodi on : {0}", codeValue);
                    break;

                case 13:
                    Console.WriteLine("Koodi on : {0}", codeValue);
                    break;

                case 14:
                    Console.WriteLine("Koodi on : {0}", codeValue);
                    break;
            }           
        }
    }
}
