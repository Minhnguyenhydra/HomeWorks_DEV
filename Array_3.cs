using System;

namespace BaiTap
{
    class Array_3
    {

        static void nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuat(int[] a, int n)
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < n; i++)
                if (a[i] % 2 == 0 || a[i] % 3 == 0)
                {

                Console.Write(a[i] + " ");
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap so ptu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[100];
            nhap(a, n);
            xuat(a, n);

            Console.ReadKey();





        }
    }
}
