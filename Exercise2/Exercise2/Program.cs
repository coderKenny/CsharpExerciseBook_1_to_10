using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height;

            double BMI;
            Console.WriteLine("This a BMI calculator\n");


            Console.Write("Input your weight in kilograms : ");
            
            
            while(!double.TryParse(Console.ReadLine(),out weight) )
            {
                Console.Write("Bad input ! ");
            }

            while(weight<50 || weight >150)
            {
                Console.Write("Bad input ! ");
                double.TryParse(Console.ReadLine(), out weight);
            }

            Apuluokka.InsertWideLineSepatator();

            Console.Write("\n\nInput your height in meters : ");        

            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("Bad input ! ");
            }

            while (height < 1.5 || height > 2.1)
            {
                Console.Write("Bad input ! ");
                double.TryParse(Console.ReadLine(), out height);
            }

            BMI = weight / (height * height);

            Apuluokka.InsertWideLineSepatator();

            Console.WriteLine("Calculated BMI : ");
            Apuluokka.InsertLines(2);

            Console.Write("{0:0.02}",BMI);

            Apuluokka.InsertLines(2);

            Apuluokka.printBMIresult(BMI);
  

            Apuluokka.Pause();

            #region Task9

            Apuluokka.InsertWideLineSepatator();

            Console.WriteLine("First Calculated BMI : {0:0.02}",BMIByValue(weight,height));
            Apuluokka.Pause();


            BMIByRef(weight, height, ref BMI);
            Console.WriteLine("\nSecond Calculated BMI : {0:0.02}", BMI);
            Apuluokka.Pause();

            BMI = 0;

            BMIByOutput(weight, height, out BMI);

            Console.WriteLine("\nThird Calculated BMI : {0:0.02}", BMI);
            Apuluokka.Pause();

            #endregion
        }

        static double BMIByValue(double weight, double height)
        {
            return weight / (height * height);
        }

        static void BMIByRef(double weight, double height, ref double BMI)
        {
            BMI = weight / (height * height);
        }

        static void BMIByOutput(double weight, double height, out double BMI)
        {
            BMI = weight / (height * height);
        }

    }
}
