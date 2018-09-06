using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class Program
    {
        static void Task1()
        {
            int[] A = new int[5];
            //numbers[0]= 1;
            //int[] numbers = new int[] {1,2,3,4,5,6,7,8,9 };
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] strings = { "", "", "" };
            int length = numbers.Length;
            // numbers.Clone создает неполную копию только первичных значений
            //numbers.CopyTo копирование

            double[,] B = new double[3, 4];
            var result = B.GetUpperBound(0);
            var RES = B.GetUpperBound(1);
            Random ran = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} число: \n");
                string a = Console.ReadLine();
                A[i] = int.Parse(a);
            }
            for (int i = 0; i < result; i++)
            {
                for (int j = 0; j < RES; j++)
                {
                    B[i, j] = ran.Next(20, 30);
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine("Значения в массиве А: " + A[i]);
            }
            Console.WriteLine("\n" + "Значения в массиве B");
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    Console.WriteLine(B[result, RES]);
                }
            }


            Console.WriteLine("Максимальное значение: " + A.Max());
            Console.WriteLine("Минимальное значение: " + A.Min());
            Console.WriteLine("Сумма всех значений: " + A.Sum());
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    sum += A[i];
                }
            }
            Console.WriteLine("Сумма четных: " + sum);
            Console.ReadLine();

        }
        static void Task2()
        {            //2.Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив общие элементы первых двух массивов без повторений. 
            int[] arrayM = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arrayN = { 4, 5, 6, 7 };
            int[] arrayResult = new int[10];
            int counter = 0;

            for(int i=0; i<arrayM.Length; i++)
            {
                for(int k=0; k < arrayN.Length; k++)
                {
                    if(arrayM[i] == arrayN[k])
                    {
                        arrayResult[counter++] = arrayM[i];
                    }
                }
            }
            foreach (var number in arrayResult)
            {
                Console.WriteLine(number);
            }
        }
        static void Task3()
        {
            Console.WriteLine("Введите строку(проверка на палиндром): ");
            string a = Console.ReadLine();
            string c = new string(a.ToCharArray().Reverse().ToArray());
            if (c == a)
            {
                Console.WriteLine("Слово является палиндромом");
            }
            else
            {
                Console.WriteLine("Слово не является палиндромом");
            }

        }
        static void Task4(string sentence)
        {
            string[] words = sentence.Split(' ');
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Кол-во слов: " + words.Length);
        }
        static void Task5()
        {
            Random ran = new Random();
            int[,] arrayDouble = new int[5,5];
            for(int i=0; i< arrayDouble.GetUpperBound(0); i++)
            {
                for(int k=0; k <arrayDouble.GetUpperBound(1); k++)
                {
                    arrayDouble[i, k] = ran.Next(-100, 100);
                }
            }

            int index_X_ofMin = 0;
            int index_Y_ofMin = 0;
            int index_X_ofMax = 0;
            int index_Y_ofMax = 0;
            for (int i=0; i < arrayDouble.GetUpperBound(0); i++)
            {
                for(int k=0; k< arrayDouble.GetUpperBound(1); k++)
                {
                    if (arrayDouble[index_Y_ofMin,index_X_ofMin] > arrayDouble[i, k])
                    {
                        index_X_ofMin = i;
                        index_Y_ofMin = k;
                    }
                    if (arrayDouble[index_Y_ofMax,index_X_ofMax] < arrayDouble[i, k])
                    {
                        index_X_ofMax = i;
                        index_Y_ofMax = k;
                    }
                }
            }

            bool isIndexMinBiggerIndexMax;
            
            if(index_X_ofMin < index_X_ofMax)
            {
                isIndexMinBiggerIndexMax = false;
            }
            else if(index_X_ofMin == index_X_ofMax)
            {
                if(index_Y_ofMin < index_Y_ofMax)
                {
                    isIndexMinBiggerIndexMax = false;
                }
                else
                {
                    isIndexMinBiggerIndexMax = true;
                }
            }
            else
            {
                isIndexMinBiggerIndexMax = true;
            }

            int result = 0;
            int begin1 = (isIndexMinBiggerIndexMax == false ? index_X_ofMin : index_X_ofMax);
            int end1 = (isIndexMinBiggerIndexMax == false ? index_X_ofMax : index_X_ofMin);
            int begin2 = (isIndexMinBiggerIndexMax == false ? index_Y_ofMin : index_Y_ofMax);
            int end2 = (isIndexMinBiggerIndexMax == false ? index_Y_ofMax : index_Y_ofMin);
            for (int i = begin1; i < end1; i++)
            {
                for(int k= begin2; k < end2; k++)
                {
                    result += arrayDouble[i, k];
                }
            }

            for (int i = 0; i < arrayDouble.GetUpperBound(0); i++)
            {
                for (int k = 0; k < arrayDouble.GetUpperBound(1); k++)
                {
                    Console.Write(arrayDouble[i, k] + " ");
                }
                Console.WriteLine('\n');
            }
            Console.WriteLine("Sum: " + result);
        }
        static void Main(string[] args)
        {
            ////int[] numbers = new int[5];
            ////numbers[0] = 1;
            ////int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            ////int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            ////string[] strings = { "asdf", "asqwer", "31adfsf" };
            ////int[,] doubleArray = new int[2,3];
            ////doubleArray[0,1]= 2;
            ////int[][] bigArray = new int[4][];
            //////bigArray[0] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            ////string a = new string(new char[] {'a','b','c'});
            //string b = "asdfasdf";
            //bool fiu= b.Contains("asdd");

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("asdasd");
            //stringBuilder.Append("asdasd");
            //stringBuilder.Append("asdasd");
            //stringBuilder.Append("asdasd");
            //stringBuilder.Append("asdasd");
            //stringBuilder.Append("asdasd");
            //stringBuilder.Append("asdasd");
            ////если больше 10 конкатениция

            //string formattedString = string.Format("Меня зовут {0}, мне {1}", "oleg", 3);

            //string name = "oleg";
            //int age = 30;

            //string interpolatedString = $"Меня зовут {name}, мне {age} лет.";

            //string anotherString = @"C:\data\file";

            //Console.WriteLine(stringBuilder.ToString());
            //Console.WriteLine(interpolatedString);

            //Console.WriteLine(fiu);
            //Task2();
            //Task4("first second third");
            //Task5();
            //Task1();
            //Task3();
            Console.ReadLine();
        }
    }
}
