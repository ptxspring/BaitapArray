using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số phần tử trong mảng: ");
            int n=int.Parse(Console.ReadLine());
            int a = 0;
            int b,c=0,d=0,e=0; // biến đếm
            var mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử số {0}: ",i);
                mang[i] = int.Parse(Console.ReadLine());
            }
            // in mảng
            Console.WriteLine("Giá trị trong mảng");
            for (int i = 0;i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------");
            // mảng đảo ngược
            Console.WriteLine("Giá trị mảng bị đảo ngược");
            Array.Reverse(mang);
            foreach (int i in mang)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------");
            // In ra giá trị giống nhau trong man

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (mang[i] == mang[j])
                    {
                        a++;
                        break;
                    }
                }
            }
            Console.WriteLine("Số lượng giá trị giống nhau: {0}",a);
            Console.WriteLine();
            Console.WriteLine("--------------");

            // In ra phần tử duy nhất trong m,ảng
            if (a == 0) Console.WriteLine("Không có giá trị duy nhất trong mảng");
            else
            {
                Console.WriteLine("Giá trị duy nhất trong mang:");
                for (int i = 0; i < n; i++)
                {
                    b = 0;
                    for (int j = 0; j < i - 1; j++) // kiểm tra giá trị giống nhau trước giá đang xét
                    {
                        if (mang[i] == mang[j])
                        {
                            b++;
                        }
                    }
                    for (int z = i + 1; z < n; z++)  // kiểm tra giá trị giống nhau sau giá đang xét
                    {
                        if (mang[i] == mang[z])
                        {
                            b++;
                        }
                    }
                    if (b == 0) Console.Write(mang[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("--------------");

            // Chia dữ liệu ra chẵcn với lẽ: Cách 1
            Console.WriteLine("Mảng chứ phần tử chẵn");
            for (int i = 0; i < n; i++)
            {
                if (mang[i]%2==0) Console.Write(mang[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Mảng chứ phần tử lẻ");
            for (int i = 0; i < n; i++)
            {
                if (mang[i] % 2 != 0) Console.Write(mang[i]+" ");
            }
            /// Cách  2
            Console.WriteLine("Cách 2"); Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------");
            var mangchan = new int[n];
            var mangle = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (mang[i] % 2 == 0)
                {
                    mangchan[c] = mang[i];
                    c++;
                }
                else
                {
                    mangle[d] = mang[i];
                    d++;
                }
            }
            Console.WriteLine("Mảng chẳn");
            Console.WriteLine();
            for (int i = 0; i < c; i++)
            {
                Console.Write(mangchan[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Mảng lẽ");
            Console.WriteLine();
            for (int i = 0; i < d; i++)
            {
                Console.Write(mangle[i]);
            }
            Console.WriteLine();
            Console.WriteLine("--------------");

            /// Sort mảng

            Console.WriteLine("Sắp xếp giá trị giảm dần");
            Array.Sort(mang);
            Array.Reverse(mang);
            foreach (int i in mang)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("--------------");

            // Tìm phần tử lớn thứ 2 trong mảng
            int max_1 = 0;
            int max_2 = 0;
            for (int i = 0;i < n; i++)
            {
                if (mang[i]>max_1)
                {
                    max_1 = mang[i];
                    e=i;
                }
            }
            for (int i = 0;i<n;i++) 
            {
                if (i == e)
                {
                    continue;
                }
                else if (mang[i] > max_2) 
                {
                    max_2= mang[i];
                }
            }
            Console.WriteLine("Giá trị lớn thứ 2 trong mảng: {0}",max_2);
            Console.ReadKey();

            
        }
    }
}
