using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursia
{
    internal class Program
    {
        static int[] GenerateRandomArray()
        {
            Console.Write("Size of the array: ");
            if (!int.TryParse(Console.ReadLine(), out int length) || length <= 0)
            {
                Dekor();
                Console.Write("Invalid Array");
                Dekor();
                return new int[0];
            }
            
            int[] array = new int[length];

            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(100);
            }
            return array;
        }

        static void GenerateManualArray(int[] array, int index = 0)
        {
            if (index < array.Length)
            {
                Console.Write((index + 1) + " Number = ");
                int.TryParse(Console.ReadLine(), out array[index]);
                index++;
                GenerateManualArray(array, index);
            }
        }


        static void OutputArray(int[] array, int startFromIndex = 0)
        {
            if (startFromIndex != array.Length)
            {
                Console.Write(array[startFromIndex] + "\t");

                startFromIndex++;

                OutputArray(array, startFromIndex);
            }
        }


        static int SumArray(int[] array, int startFromIndex = 0, int elseSum = 0)
        {
            if (startFromIndex != array.Length)
            {
                elseSum = elseSum + array[startFromIndex];
                startFromIndex++;

                return SumArray(array, startFromIndex, elseSum);
            }
            else return elseSum;
        }


        static int NumberSum(int number, int elseSum = 0)
        {
            if (number != 0)
            {
                elseSum += number % 10;
                number = number / 10;

                return NumberSum(number, elseSum);
            }
            return elseSum;
        }


        static void Dekor()
        {
            Console.WriteLine();
            for (int i = 0; i < 120; i++)
            {
                Console.Write("-");
            }
        }


        static void Main(string[] args)
        {
            int[] myArray = GenerateRandomArray();
            if (myArray.Length == 0)
                return;

            //GenerateManualArray(myArray);   //If you want to enter an array manually

            Dekor();
            Console.Write("Your array:\t");
            OutputArray(myArray);
            Dekor();

            Console.Write("\nThe sum of array numbers = " + SumArray(myArray));

            Dekor();

            Console.Write("The number to calculate its sum: ");

            if(!int.TryParse(Console.ReadLine(), out int number))
            {
                Dekor();
                Console.Write("Invalid Number");
                Dekor();
                return;
            }

            Dekor();
            Console.Write("Sum of digits = " + NumberSum(number));
            Dekor();
        }
    }
}
