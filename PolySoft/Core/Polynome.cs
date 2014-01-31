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
        private static char[] operators;

        #endregion

        // Get & Set.

        #region Get & Set

        public char[] Operators
        {
            get { return operators; }
        }
        public string[] Polynome
        {
            get { return gotPolynome; }
        }

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
            operators = new char[numberOfOperators];
            newPolynome = new string[numberOfOperators + 1];
            /* Get operators */
            int n = 0;
            for (int i = 0; i < polynome.Length; i++)
            {
                if (n < operators.Length && (polynome[i] == '+' || polynome[i] == '*' || polynome[i] == '-' || polynome[i] == '/'))
                {
                    operators[n] = polynome[i];
                    n++;
                }
            }
            /* Remove all polynome's operators */
            newPolynome = polynome.Split(new char[]{'+', '-', '*', '/'});

            return newPolynome;
        }

        #endregion
    }
}
