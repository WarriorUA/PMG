using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLab_V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k;
            int countVidem;

            StreamReader srReader = new StreamReader("input.txt");
            n = int.Parse(srReader.ReadLine());

            int[] array = new int[n];
            string arrayString = srReader.ReadLine();
            string[] arrayInt = arrayString.Split(' ');
            int i = 0;
            foreach (var t in arrayInt)
            {
                array[i] = int.Parse(t);
                i++;
            }

            k = int.Parse(srReader.ReadLine());
            srReader.Close();
            StreamWriter sw = new StreamWriter("output.txt");
            switch (k)
            {
                case 1:
                {
                        array = Sort(array, n);
                        break;
                    }
                case 2:
                    countVidem = Videm(array);
                    sw.Write(countVidem);
                    break;
                case 3:
                    {
                        array = Kratni(array, n);
                        foreach (var t in array)
                        {
                            sw.Write(t + " ");
                        }
                        break;
                    }
            }
            sw.Close();
        }
        public static int[] Sort(int[] array, int n)
        {
            bool flag = false;
            while (!flag)
            {
                flag = true;
                for (int i = 1; i < n; ++i)
                {
                    if (array[i] < array[i - 1])
                    {
                        int t = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = t;
                        flag = false;
                    }
                }
                for (int i = n - 1; i >= 0; --i)
                {
                    if (array[i] > array[i - 1])
                    {
                        int t = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = t;
                    }
                }
            }
            return array;
        }

        public static int Videm(int[] array)
        {
            int k = 0;
            foreach (var t in array)
            {
                if (t <0) ++k;
            }
            return k;
        }

        public static int[] Kratni(int[] array, int n)
        {
            for (int i = 0; i < n; ++i)
            {
                if (array[i] %2==0 || array[i] %7==0) array[i] +=10;
            }
            return array;
        }
    }
}

