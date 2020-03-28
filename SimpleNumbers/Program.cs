using System;

namespace SimpleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplyNumber simplyNumber = new SimplyNumber();
            var n = simplyNumber.getN();
            var arr = simplyNumber.createArray(n);
            simplyNumber.findSimpleNumbers(arr);
            

        }
    }

    class SimplyNumber
    {
        public int getN()
        {
            int n;
            string nString;
            Console.WriteLine("Введите число n");
            nString = Console.ReadLine();
            try
            {
                n = int.Parse(nString);
                return n;
            }
            catch
            {
                return 0;
            }



        }
        public int[] createArray(int n)
        {
            int[] arrNumbers = { 1 };
            if (n > 0)
            {
                arrNumbers = new int[n];
                int i = 0;
                while (i < arrNumbers.Length)
                {
                    arrNumbers[i] = i++;
                }
            }
            
            return arrNumbers;
        }

        public void findSimpleNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var isSimple = true;
               for(int j = 2;j<arr[i];j++)
                {
                    if ((arr[i] % j ==0))
                    {
                        isSimple = false;
                        break;
                    }
                }
                if (isSimple && arr[i] > 1)
                    Console.WriteLine(arr[i]);
            }
            }
        }
    }

