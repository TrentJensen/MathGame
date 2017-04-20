using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assignment5
{
    public class clsGame
    {
        #region Attributes

        /// <summary>
        /// Array of two ints to hold random values
        /// </summary>
        public int[] randNum = new int[2];

        /// <summary>
        /// Stores which operator is being used
        /// </summary>
        public string operation = "+";

        /// <summary>
        /// Keeps track of the score for the current game
        /// </summary>
        public int correctAns = 0;

        public int incorrectAns = 0;

        #endregion

        #region Methods

        /// <summary>
        /// Creates two random numbers (depending on operation) for randNum array.
        /// </summary>
        public void generateNums()
        {
            try
            {
                Random random = new Random();
                if (operation == "+")
                {
                    randNum[0] = random.Next(0, 21);
                    randNum[1] = random.Next(0, 21);
                }
                else if (operation == "-")
                {
                    do
                    {
                        randNum[0] = random.Next(0, 21);
                        randNum[1] = random.Next(0, 21);
                    }
                    while (randNum[0] < randNum[1]);
                }
                else if (operation == "x")
                {
                    randNum[0] = random.Next(0, 13);
                    randNum[1] = random.Next(0, 13);
                }
                else
                {
                    do
                    {
                        randNum[0] = random.Next(0, 16);
                        randNum[1] = random.Next(1, 16);
                    }
                    while (randNum[0] % randNum[1] != 0);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + 
                    MethodInfo.GetCurrentMethod().Name + " ->" + ex.Message);
            }
        }

        /// <summary>
        /// Returns specified randNum array as a string
        /// </summary>
        /// <param name="num">0 or 1, first or second random number</param>
        /// <returns>Returns randNum as string</returns>
        public string returnNum(int num)
        {
            try
            {
                return Convert.ToString(randNum[num]);
            }
            catch(Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " ->" + ex.Message);
            }
        }

        /// <summary>
        /// Checks if user's answer is correct
        /// </summary>
        /// <param name="answer">The user's input</param>
        /// <returns>True if correct</returns>
        public bool checkAnswer(int answer)
        {
            try
            {
                if (operation == "+")
                {
                    if (randNum[0] + randNum[1] == answer)
                    {
                        correctAns++;
                        return true;
                    }
                    else
                    {
                        incorrectAns++;
                        return false;
                    }
                }
                else if (operation == "-")
                {
                    if (randNum[0] - randNum[1] == answer)
                    {
                        correctAns++;
                        return true;
                    }
                    else
                    {
                        incorrectAns++;
                        return false;
                    }
                }
                else if (operation == "x")
                {
                    if (randNum[0] * randNum[1] == answer)
                    {
                        correctAns++;
                        return true;
                    }
                    else
                    {
                        incorrectAns++;
                        return false;
                    }
                }
                else if (operation == "/")
                {
                    if (randNum[0] / randNum[1] == answer)
                    {
                        correctAns++;
                        return true;
                    }
                    else
                    {
                        incorrectAns++;
                        return false;
                    }
                }
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " ->" + ex.Message);
            }
        }

        #endregion
    }
}
