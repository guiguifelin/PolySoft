using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolySoft
{
    public class Polynome
    {
        // Fields.

        #region Private fields

        private static string[] gotPolynome;
        private static int[] operators;

        #endregion

        // Methods.

        #region Methods

        public static string[] GetPolynome(string polynome)
        {
            /* Fields */
            int numberOfOperators = 0;
            string[] newPolynome;

            /* Get count of operators in this polynome */
            for (int i = 0; i < polynome.Length; i++)
            {
                if (polynome[i] == '+' || polynome[i] == '*' || polynome[i] == '-' || polynome[i] == '/')
                {
                    numberOfOperators++;
                }
            }
            /* Initialize operators array */
            operators = new int[numberOfOperators];
            newPolynome = new string[numberOfOperators + 1];
            /* Get operators */
            for (int i = 0; i < polynome.Length; i++)
            {
                if (i < operators.Length && (polynome[i] == '+' || polynome[i] == '*' || polynome[i] == '-' || polynome[i] == '/'))
                {
                    operators[i] = polynome[i];
                }
            }
            newPolynome = polynome.Split(new char[]{'+', '-', '*', '/'});

            return newPolynome;
        }

        #endregion
    }
}
