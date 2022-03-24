using System;

namespace CSharp_String_Array_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChangeString("    salam        dunya    ");
            Console.WriteLine(CheckStr("salam1A2"));
            Console.WriteLine(FirstWord("    salam        dunya    "));
            Console.WriteLine(ChekForTwoStr("    Salam        Dunya    "));

            int[] arr = { 1, 2, 3, 4, 5, 6, };

            foreach (var item in AddInt(ref arr, 7))
            {
                Console.WriteLine(item);    
            }
        }

        //task-1
        static void ChangeString(string str)
        {
            string[] strArr = str.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            str = String.Join(" ", strArr);
            Console.WriteLine(str);
        }

        //task-2
        static bool CheckStr(string str)
        {
            char[] chars = str.ToCharArray();
            bool checkDigit = false;
            bool checkUpper = false;
            bool checkLower = false;

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsDigit(chars[i]))
                    checkDigit = true;
                if(char.IsUpper(chars[i]))
                    checkUpper = true;
                if (char.IsLower(chars[i]))
                    checkLower = true;

                
            }
            if (checkDigit && checkLower && checkUpper)
                return true;
            else
                return false;
        }

        //task-3
        static string FirstWord(string str)
        {
            string[] strArr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return strArr[0];
        }

        //task-4    
        static bool ChekForTwoStr(string str)
        {
            string[] strArr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (strArr.Length == 2)
            {
                int count = 0;
                for (int i = 0; i < strArr.Length; i++)
                {
                    if (char.IsUpper(strArr[i][0]))
                    {
                        count++;
                    }
                }
                if (count == 2)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        //task-5
        static int[] AddInt(ref int[] arr, int val)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = val;
            return arr;
        }
    }
}
