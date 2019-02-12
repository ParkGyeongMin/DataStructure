// 재귀

using System;
using System.Runtime.InteropServices.ComTypes;

namespace Recursion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Recursive(4); 
            Rev.Recursive(4); // Class 

            Console.Write("값을 입력하세요 . : ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("1~num 까지의 합" + Sum(num));
            Console.WriteLine("1~num 까지의 곱" + multiplication(num));
            Console.WriteLine("Class 1~num 까지의 합" + Rev.sum(num));
            Console.WriteLine("Class 1~num 까지의 곱" + Rev.multiplication(num));

        }
        
        
        static void Recursive(int num)
        {
            if (num <= 0) // 0보다 크거나 같으면 종료 하기 위해 사용
            {
                return ;
            }

            Console.WriteLine("Recursive Call! !");
            // Console.WriteLine(num);
            Recursive(num - 1); // 자기 자신을 호출하면서 num의 값을 계속 빼주고 있다. 
        }

        
        static int Sum(int num)
        {
            if (num == 0)
                return 0;
            else 
                return num + Sum(num - 1);
            
        }

        static int multiplication(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else
                return num * multiplication(num - 1);
        }

        // 위에꺼와 똑같은 동작을 한다. 재귀 동작을 클래스로 묶어서 사용 한다.
        class Rev
        {

            public static void Recursive(int num)
            {
                if (num <= 0)
                {
                    return; 
                }
                Console.WriteLine("Class Recursive Call ! ");
                Recursive(num - 1 );
            }

            public static int sum(int num) // 1~입력받은 값 까지 + 
            {

                if (num == 0)
                {
                    return 0;
                }
                else
                {
                    return num + sum(num - 1);
                }

            }

            public static int multiplication(int num) // 1~입력받은 값 까지 * 
            {
                if (num == 0)
                {
                    return 0;
                }
                else if (num == 1)
                {
                    return 1;
                }
                else
                {
                    return num * multiplication(num - 1);
                }
            }
        }

    }
}
