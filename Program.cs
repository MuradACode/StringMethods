using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string Trim(string word)
            {
                int t = 0;
                char[] tempCharArray = word.ToCharArray();
                char[] trimmedStartArr = new char[tempCharArray.Length];
                int lenght = tempCharArray.Length;
                for (int i = 0; i < tempCharArray.Length; i++)
                {
                    while (tempCharArray[i] != ' ')
                    {
                        lenght--;
                        for (; i < tempCharArray.Length; i++)
                        {
                            trimmedStartArr[t] = tempCharArray[i];
                            t++;
                        }
                        break;
                    }

                }
                t = 0;
                char[] trimmedStart = new char[lenght];
                for (int i = 0; i < lenght; i++)
                {
                    trimmedStart[t] = trimmedStartArr[i];
                    t++;
                }
                t = trimmedStart.Length - 1;
                lenght = trimmedStart.Length;
                char[] trimmedEndArr = new char[trimmedStart.Length];
                for (int i = trimmedStart.Length - 1; i >= 0; i--)
                {
                    while (trimmedStart[i] != ' ')
                    {
                        lenght--;
                        for (; i >= 0; i--)
                        {
                            trimmedEndArr[t] = trimmedStart[i];
                            t--;
                        }
                        break;
                    }
                }
                t = lenght - 1;
                char[] trimmedEnd = new char[lenght];
                for (int i = lenght - 1; i >= 0; i--)
                {
                    trimmedEnd[t] = trimmedEndArr[i];
                    t--;
                }
                string trimmedString = new string(trimmedEnd);
                return trimmedString;
            }
            int IndexOf(string word, char character)
            {
                char[] tempCharArray = word.ToCharArray();
                for (int i = 0; i < tempCharArray.Length; i++)
                {
                    if (tempCharArray[i] == character)
                    {
                        return i;
                    }
                }
                Console.WriteLine("This character is missing in this word");
                return 0;
            }
            bool Contains(string word, char character)
            {
                bool contains = false;
                char[] tempCharArray = word.ToCharArray();
                for (int i = 0; i < tempCharArray.Length; i++)
                {
                    if (tempCharArray[i] == character)
                    {
                        return contains = true;
                    }
                }
                return contains;
            }
        }
    }
}
