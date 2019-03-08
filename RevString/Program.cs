using System;
using System.Linq;

namespace RevString
{
    internal class Program
    {
        static void ReversetStr(char[] str)
        {
            int length = str.Length;
            for (int i = 0; i < length/2; i++)
            {
                char temp = str[i];
                str[i] = str[length - i - 1];
                str[length - i - 1] = temp;
            }
        }
        
        public static void Main(string[] args)
        {

            Console.Write("원하는 문자열을 입력하세요.");
            string input = Console.ReadLine();
            char[] str = input.ToCharArray(), str2;
            
            ReversetStr(str);
            
            
            foreach (var s in str)
            {
                Console.Write(s);
            }


            // 연속된 문자열 제거 추가 중.... ( 계속 안되서 고민 ) 
            // ex ) aaaassssddddeeeeffffdddssssaaaa = asdefdsa 
            

        }
    }
}