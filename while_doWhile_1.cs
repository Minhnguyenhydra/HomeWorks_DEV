using System;

namespace BaiTap
{
    class Array_1

    {

        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap vao n= ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while (i < n)
            {
                if (i % 2 == 0 & i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
                sum += i;
            }

            Console.WriteLine("Tong cua 0 den n chia het cho 2 va 3 la:" + sum);

            Console.ReadLine();






        }
    }
}
