using System.Diagnostics;
using System.Text;

namespace CodingInterviewPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var ReverseString = ReverseAString("Hello World");

            //var Pallindrome = PallindromeOrNot("madam");

            var ReversedWord = ReverseWordOfString("A Quick Brown Fox Jump Over a Lazy Dog");

            //var ReverseEachWord = ReverseEachWordOfString("A Quick Brown Fox Jump Over a Lazy Dog");

            Console.WriteLine(ReversedWord);
        }

        /// <summary>
        /// Reversing a String using Two-Pointers (The user will input a string and the method should return the reverse of that string)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></re turns>
        public static string ReverseAString(string str)
        {

            char[] chars = str.ToCharArray();

            for(int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                chars[i] = str[j];
                chars[j] = str[i];
            }

            string reversedString = new string(chars);
            return reversedString;
        }

        /// <summary>
        /// Check For String is Pallindrome or Not, if  Pallindrome return Pallindrome if not return Not Pallindrome
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string PallindromeOrNot(string str)
        {

            bool flag = false;
            string resultString = "Not Palindrome";


            ///Two Pointer Method
            //char[] chars = str.ToLower().ToCharArray();


            //for(int i=0, j = str.Length - 1; i < j; i++, j--)
            //{
            //    chars[i] = str[j];
            //    chars[j] = str[i];
            //}

            //string reversedString = new string(chars);

            //if(str == reversedString)
            //{
            //    resultString = "Pallindrome";
            //}


            ///Different Method
            ///

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    break;
                }
                else
                {
                    resultString = "Palindrome";
                    flag = true;
                }
            }

            return resultString;
        }

        /// <summary>
        /// Reversing Words of String Using Split In-Built Function of C#
        /// A Quick Brown Fox Jump Over a Lazy Dog ---->> Dog Lazy a Over Jump Fox Brown Quick A
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseWordOfString(string str)
        {
            string[] stringArrayOfWords = str.Split(' ');
            var ReversedWord = new StringBuilder();

            for(int i = stringArrayOfWords.Length - 1; i >= 0; i--)
            {
                if(i == 0)
                {
                    ReversedWord.Append(stringArrayOfWords[i]);
                } else
                {
                    ReversedWord.Append(stringArrayOfWords[i]).Append(" ");
                }
            }

            return ReversedWord.ToString();
        }

    }
}