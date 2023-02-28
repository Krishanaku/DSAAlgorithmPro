namespace DSAAlogrithmPro
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Lowest of value between 0 to 1000: ");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Lowest of value between 0 to 1000: ");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Prime Number : {0}", i);
                }
            }

            Console.WriteLine("Palindrome numbers in the range {0}, {1}:", start, end);

            for (int num = start; num <= end; num++)
            {
                if (IsPalindrome(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static bool IsPalindrome(int num)
        {
            int originalNum = num;
            int reversedNum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = reversedNum * 10 + digit;
                num /= 10;
            }

            return originalNum == reversedNum;


        }


    }
}
