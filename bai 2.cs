using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    public class ArrayProcessor

    {
        
         private int n;
        private int[] arr;
        public void Input()
        {
            Console.WriteLine("nhap so phan tu mang");
            n=int.Parse(Console.ReadLine());
            arr = new int[n];
            Console.WriteLine("nhap cac gia tri mang");
           for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

        }

        public void Display()
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }

        public void bubbleShort()
        {

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public int LinearSearch(int key)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == key)
                    return i; // trả về vị trí tìm thấy
            }
            return -1; // không tìm thấy
        }



        static void Main()
        {
            ArrayProcessor mang = new ArrayProcessor();
            mang.Input();
            mang.Display();
            Console.WriteLine();

            /*mang.bubbleShort();
          Console.WriteLine("mang sau khi sap xep ");
            mang.Display() ;*/

            
            Console.WriteLine("nhap 1 so ");
            int key = int.Parse(Console.ReadLine());


            Console.ReadLine();
        }
    }
}
