using System;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string stringValue)
        {
            if (stringValue == null)
                throw new ArgumentNullException();

            if (string.IsNullOrWhiteSpace(stringValue) || (stringValue.Contains("+") && stringValue.Contains("-")) || !isNumber(stringValue))
            {
                throw new FormatException();
            }

            int response = 0;
            bool isNegative = false;
            int count = 0;

            foreach (char c in stringValue)
            {
                count++;
                if (c == '+')
                    continue;

                else if (c == '-')
                {
                    isNegative = true;
                    continue;
                }

                else if (char.IsWhiteSpace(c))
                    continue;

                checked
                {
                    try
                    {
                        response *= 10;
                        if (isNegative && count == stringValue.Length)
                        {
                            response *= -1;
                            response -= c - '0';
                            isNegative = false;
                            continue;
                        }
                        response += c - '0';
                    }
                    catch (OverflowException ex)
                    {
                        throw ex;
                    }
                }

            }
            if (isNegative)
            {
                response *= -1;
            }

            return response;
        }

        private bool isNumber(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsWhiteSpace(str[i]))
                {
                    continue;
                }
                if ((str[i] > 57 || str[i] < 48) && (str[i] != 43 && str[i] != 45) || (i != 0 && (str[i] == 45 || str[i] == 43)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}