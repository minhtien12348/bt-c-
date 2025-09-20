using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main()
        {
            /*int m;
            Console.WriteLine("nhap so dong ma tran A");
            m=int.Parse(Console.ReadLine());
            int n;
            Console.WriteLine("nhap so cot ma tran A va la dong ma tran B");
            n = int.Parse(Console.ReadLine());
            int p;
            Console.WriteLine("nhap so cot ma tran B");
            p=int.Parse(Console.ReadLine());

            int[,] A=new int[m,n];
           // int[,] B = new int[n,p];
            //int[,] C = new int[m,p];

            Console.WriteLine("nhap gia tri mang A ");
            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    A[i,j] = int.Parse(Console.ReadLine());
                }
                
            }


            Console.WriteLine("nhap gia tri mang B ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    B[i, j] = int.Parse(Console.ReadLine());
                }
           }

            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    C[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }

            }

            Console.WriteLine("ket qua ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    Console.Write(C[i, j]+" "); 
                }
                Console.WriteLine();
            }*/

            //chuyen vi ma tran

            /*Console.Write("Nhập số hàng của ma trận: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột của ma trận: ");
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[m, n];
            int[,] AT = new int[n, m]; // Ma trận chuyển vị

            // Nhập ma trận A
            Console.WriteLine("Nhập ma trận A:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"A[{i},{j}] = ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Tính ma trận chuyển vị
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    AT[j, i] = A[i, j];
                }
            }

            // Xuất ma trận A
            Console.WriteLine("\nMa trận A:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Xuất ma trận A^T
            Console.WriteLine("\nMa trận chuyển vị A^T:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(AT[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.ReadLine();*/

            //Tìm giá trị lớn nhất và nhỏ nhất

            Console.Write("Nhập số hàng của ma trận: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột của ma trận: ");
            int n = int.Parse(Console.ReadLine());

            int[,] A = new int[m, n];
            Console.Write("Nhập gia tri ma trận: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }

              }

            int min = A[0, 0];
            int max = A[0, 0];


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] > max)
                        max = A[i, j];
                    if (A[i, j] < min)
                        min = A[i, j];
                }

            }
            Console.WriteLine("gia tri lon nhat la "+max);
            Console.ReadLine();


        }
    }
}

