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

        private static char[] operators;

        #endregion

        // Get & Set.

        #region Get & Set

        public char[] Operators
        {
            get { return operators; }
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

            /* Prepare the polynome to the evaluation */
            for (int i = 0; i < newPolynome.Length; i++)
            {
                if (newPolynome[i].Contains('x') && !newPolynome[i].Contains('^'))
                {
                    newPolynome[i] += "^1";
                }
                else if (!newPolynome[i].Contains('x'))
                {
                    newPolynome[i] += "x^0";
                }
            }

            return newPolynome;
        }
        public static string[] Evaluate(string[] polynome)
        {
            /* Fields */
            string[] newPolynome = new string[operators.Length + 1];
            int puissance = 0, j = 0, sum = 0;

            /* Algorithms */

            /* Determined if '*' or '/' is in the polynome */
            while (j < operators.Length && (operators[j] != '*' || operators[j] != '/'))
            {
                j++;
            }

            if (j < operators.Length)
            {
                /* Fix ME*/
            }
            else
            {
                int l = 0;
                /* Search a '(' in polynome */
                while (l < polynome.Length && !polynome[l].Contains('('))
                {
                    l++;
                }

                if (l < polynome.Length)
                {
                    //for (int i = 0; i < polynome.Length; i++)
                    //{
                    //    for (int n = 0; n < polynome[i].Length; n++)
                    //    {
                    //        if (polynome[i][n] == '(' && polynome[i][n-1] == ')')
                    //        {
                    //            string parenthèse = "";
                    //            for (int a = 0; a < parenthèse.Length; a++)
                    //            {
                    //                parenthèse += polynome [i][a];
                    //            }
                    //        }
                    //    }
                    //}
                }
                else
                {
                    /* Search the power */
                    for (int i = 0; i < polynome.Length; i++)
                    {
                        for (int n = 0; n < polynome[i].Length; n++)
                        {
                            if (polynome[i][n] == '^' && polynome[i][n - 1] == 'x')
                            {
                                string pui = "";
                                for (int p = n + 1; p < polynome[i].Length; p++)
                                {
                                    pui += polynome[i][p];
                                }
                                if ((int)Convert.ToInt64(pui) > puissance)
                                {
                                    puissance = (int)Convert.ToInt64(pui);
                                }
                            }
                        }
                    }
                    /* Evaluate the polynome */
                    int a = 0, b = 0;
                    while (puissance >= 0)
                    {
                        for (int i = 0; i < polynome.Length; i++)
                        {
                            for (int n = 0; n < polynome[i].Length; n++)
                            {
                                if (polynome[i][n] == '^' && polynome[i][n - 1] == 'x')
                                {
                                    string pui = "";
                                    for (int p = n + 1; p < polynome[i].Length; p++)
                                    {
                                        pui += polynome[i][p];
                                    }
                                    if ((int)Convert.ToInt64(pui) == puissance)
                                    {
                                        string number = "";
                                        for (int r = 0; r < n - 1; r++)
                                        {
                                            number += polynome[i][r];
                                        }
                                        /* Determined if the first term is negative */
                                        if (number != "")
                                        {
                                            if (polynome[operators.Length] == null)
                                            {
                                                if (operators[i] == '-')
                                                {
                                                    sum += (-1) * (int)Convert.ToInt64(number);
                                                }
                                                else
                                                {
                                                    sum += (int)Convert.ToInt64(number);
                                                }
                                            }
                                            else
                                            {
                                                if (i > 0 && operators[b] == '-')
                                                {
                                                sum += (-1) * (int)Convert.ToInt64(number);
                                                }
                                                else
                                                {
                                                    sum += (int)Convert.ToInt64(number);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            b++;
                        }
                        /* Integrate it in the new polynome array */
                        if (a < newPolynome.Length)
                        {
                            newPolynome[a] = sum + "x^" + puissance;
                        }
                        puissance--;
                        sum = 0;
                        a++;
                    }
                }
            }
            return newPolynome;
        }
        public static string ToString(string[] polynome)
        {
            string text = "";
            //Convert.ToInt32(text);
            /* Convert in string */
            for (int i = 0; i < polynome.Length; i++)
            {
                if (polynome[i] != null && polynome[i][0] != '0')
                {
                    if (polynome[operators.Length] == "")
                    {
                        text += operators[i] + polynome[i];
                    }
                    else if (i > 0)
                    {
                        text += operators[i - 1] + polynome[i];
                    }
                    else
                    {
                        text += polynome[i];
                    }
                }
            }

            return text;
        }

        #endregion
    }
}
