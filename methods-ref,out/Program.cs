using System;

namespace methods_ref_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 16;
            Console.WriteLine(NumLent(num));
        }
        static int NumLent (int num)
        {
            num = 16;
            int count = 0;
            while (num > 0) 
            
            {
                num/= 10;
                count++;
            }
            return count;
        }
    }
}
