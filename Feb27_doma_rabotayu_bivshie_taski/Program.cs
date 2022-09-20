using System;

namespace Feb27_doma_rabotayu_bivshie_taski
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FindMax
            //int[] array = new int[10];
            //Console.WriteLine("Salam, bizim saytda daxil etdiyiniz regemlerden en boyuyunu tapa bilersiz");
            //int i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine("Regem daxil edin:");
            //    string str = Console.ReadLine();
            //    int num = int.Parse(str);
            //    Array.Resize(ref array, 10);
            //    array[i] = num;
            //    i++;
            //}
            //Console.WriteLine($"Sizin daxil etdiyiniz regemlerden {FindMax(array)} en boyukdur");
            #endregion

            #region CalcNums
            //Console.WriteLine("Salam\nRegem daxil edin, biz size onun regemlerinin sayini deyek:");
            //string a = Console.ReadLine();
            //int input = int.Parse(a);
            //Console.WriteLine(CalcNums(input));
            #endregion

            #region Market

            //int[] array = new int[3];
            //Console.WriteLine("Salam, bizim saytdan alacaginiz 3 mehsulun giymetin yazin, en ucuzunu pulsuz aparin!");
            //int i = 0;

            //while (i < 3)
            //{
            //    Console.WriteLine("Qiymet daxil edin:");
            //    string str = Console.ReadLine();
            //    int num = int.Parse(str);
            //    Array.Resize(ref array, 3);
            //    array[i] = num;
            //    i++;
            //}
            //Console.WriteLine($"Sizin daxil etdiyiniz qiymetlere esasen siz {Market(array)} odeyeceksiniz.");

            #endregion
        }
        #region CalcNums

        //static int CalcNums(int a)
        //{
        //    int sum = 0;
        //    int Sum = 0;
        //    while (a > 0)
        //    {
        //        sum = a % 10;
        //        a = (a - sum) / 10;
        //        Sum += sum;
        //        //sum += (a - a % 10) / 10;
        //    }
        //    return Sum;
        //}
        #endregion

        #region FindMax
        //static int FindMax(int[] arr)
        //{
        //    Array.Sort(arr);
        //    return arr[arr.Length - 1];
        //}
        #endregion

        #region Market
        //static int Market(int[] arr)
        //{
        //    Array.Sort(arr);
        //    int a = arr[1] + arr[2];
        //    return a;
        //}

        #endregion
    }
}
