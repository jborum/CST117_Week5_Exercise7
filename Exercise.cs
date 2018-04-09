/*
 * Exercise 7
 * This program was written by Jason Borum
 * Date April 8, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Exercise
    {
        //Method to return sum of two integers
        public int showSum(int integer1, int integer2)
        {
            return (integer1 + integer2);
        }

        //Method to return the average of 5 doubles
        public double showAverage(double number1, double number2, double number3, double number4, double number5)
        {
            return ((number1 + number2 + number3 + number4 + number4 + number5) / 5.0);
        }

        //Method to return sum of two random integers
        public int randomSum()
        {
            Random randNum = new Random();
            int randNum1 = randNum.Next(1, 100);
            int randNum2 = randNum.Next(1, 100);
            return (randNum1 + randNum2);
        }

        //Method to return sum of two integers
        public bool showSum(int integer1, int integer2, int integer3)
        {
            if (((integer1 + integer2 + integer3) % 3) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to return longest of two string
        public string showLongerString(string string1, string string2)
        {
            if (string1.Length > string2.Length)
            {
                return string1;
            }
            else {
                return string2;
            }
        }

        //Method to return the average of 5 doubles
        public double showLargestDouble(double[] arrayOfDoubles)
        {
            int maxIndex = -1;
            double maxDouble = 0;

            for (int i = 0; i < arrayOfDoubles.Length; i++)
            {
                double getvalue = arrayOfDoubles[i];
                if (getvalue > maxDouble)
                {
                    maxDouble = getvalue;
                    maxIndex = i;
                }
            }
            return maxDouble;
        }

        //Method to generate and return an array of 50 integers
        public int[] randomArrayOfIntegers()
        {
            Random randNum = new Random();
            int[] arrayOfIntegers = new int[50];

            for (int i = 0; i < 50; i++)
            {
                int randNum1 = randNum.Next(1, 100);
                arrayOfIntegers[i] = randNum1;
            }

            return arrayOfIntegers;
        }

        //Method to compare two bools
        public bool showBool(bool bool1, bool bool2)
        {
            if (bool1 == bool2)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        //Method to return product of int and double
        public double showSum(int integer1, double double1)
        {
            return (Convert.ToDouble(integer1) * double1);
        }

        //Method to return the average of multi-array
        public double showAverageOfIntegers(int[][] arrayOfDoubles)
        {
            int sumOfArray = 0;
            int totalValues = arrayOfDoubles.Length + arrayOfDoubles[1].Length;

            for (int i = 0; i < arrayOfDoubles.Length; i++)
            {
                for (int j = 0; j < arrayOfDoubles[i].Length; j++)
                    sumOfArray = sumOfArray + arrayOfDoubles[i][j];
            }
            return sumOfArray / totalValues;
        }

    } // end of class
} // end of namespace
