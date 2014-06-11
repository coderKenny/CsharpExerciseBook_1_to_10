using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2
            int alpha, bravo, charlie;
            string str1 = "100";
            Console.WriteLine("MyExercise1");
            Console.WriteLine("---------------------------");
            Console.Write("Anna integer1 : ");
            alpha = int.Parse(Console.ReadLine());
            Console.Write("Anna integer2 : ");
            bravo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------");

            Console.WriteLine("Sum of numbers : {0} ", alpha + bravo);

            Console.WriteLine("---------------------------");

            Console.WriteLine("Multiple of numbers : {0} ", alpha * bravo);

            Console.WriteLine("---------------------------");

            int.TryParse(str1, out charlie);

            Console.WriteLine("Multiple of numbers : {0} ", charlie);

            Console.WriteLine("---------------------------");

            #endregion

            #region 3

            const float MyOwnPi = 3.14f;

            Console.WriteLine("Circumference of a circle : {0:0.000} ", MyOwnPi * alpha);

            Console.WriteLine("---------------------------");

            #endregion

            #region 4

            object MyObject = alpha;

            Console.WriteLine("---------------------------");

            Console.WriteLine("My objectin arvo : {0}", MyObject);

            Console.WriteLine("My objectin arvo : {0}", MyObject.GetType());

            #endregion

            #region 5

            int[] MyArrayA= { 1,2,3,4,5 };

            MyArrayA[2] = 111;

            Console.WriteLine("---------------------------");

            foreach (Int32 integer in MyArrayA)
            {
                Console.WriteLine("{0}",integer);
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("{0}", MyArrayA[0]);
            Console.WriteLine("{0}", MyArrayA[2]);
            Console.WriteLine("{0}", MyArrayA[4]);

            Console.WriteLine("---------------------------");

            Array.Sort(MyArrayA);

            

            foreach (Int32 integer in MyArrayA)
            {
                Console.WriteLine("{0}", integer);
            }


            Array.Reverse(MyArrayA);

            Console.WriteLine("---------------------------");

            foreach (Int32 integer in MyArrayA)
            {
                Console.WriteLine("{0}", integer);
            }


            int[,] MyArrayB = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };

            Console.WriteLine("---------------------------");

            Console.WriteLine("MyArrayB has {0} lines",MyArrayB.GetLength(0));
            Console.WriteLine("MyArrayB has {0} columns", MyArrayB.GetLength(1));

            #endregion

            #region 8

            Console.WriteLine("---------------------------");

            Console.WriteLine("MyArrayA for :");

            for(int i=0;i<MyArrayA.GetLength(0);i++)
                Console.WriteLine("{0}",MyArrayA[i]);

            Console.WriteLine("---------------------------");

            Console.WriteLine("MyArrayA foreach :");

            foreach(object obj in MyArrayA)
                Console.WriteLine("{0}", obj);


            Console.WriteLine("---------------------------");

            Console.WriteLine("MyArrayB for :");

            for (int i = 0; i < MyArrayB.GetLength(0); i++)
            {
                for(int j=0;j<MyArrayB.GetLength(1);j++)
                    Console.WriteLine("{0}", MyArrayB[i,j]);

            }


            Console.WriteLine("---------------------------");

            Console.WriteLine("MyArrayB foreach :");


            foreach (object obj in MyArrayB)
            {
                Console.WriteLine("{0}", obj);
            }

            #endregion


            Apuluokka.Pause();
        }
    }
}
