using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLab_V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k;
            int countNepar;

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
                        foreach (var t in array)
                        {
                            sw.Write(t+" ");
                        }
                        break;
                    }
                case 2:
                    countNepar = Nepar(array);
                    sw.Write(countNepar);
                    break;
                case 3:
                    {
                        array = Zamina(array, n);
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
            }
            return array;
        }

        public static int Nepar(int[] array)
        {
            int k = 0;
            foreach (var t in array)
            {
                if (t % 2 == 1) ++k;
            }
            return k;
        }

        public static int[] Zamina(int[] array, int n)
        {
            for (int i = 0; i < n; ++i)
            {
                if (array[i] > 2 && array[i] < 17) array[i] *= array[i];
            }
            return array;
        }
    }
}




