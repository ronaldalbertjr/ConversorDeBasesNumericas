using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbeToBinaryConverter
{
    static class Bin
    {   
        public static string numberToBin(ulong n)
        {
            string bin = "";
            if(n < 0)
            {
                throw new NegativeNumberException();
            }
            if (n == 0)
            {
                return "0";
            }
            while (n != 1)
            {
                bin += Convert.ToString(n % 2);
                n = n / 2;
            }
            bin += "1";
            char[] bina = new char[bin.Length];
            bina = bin.ToCharArray();
            Array.Reverse(bina);
            return new string(bina);
        }
        public static string numberToHexadecimal(ulong n)
        {
            List<string> hexa = new List<string>();
            string hexad = "";
            int number = 0;
            int counter = 0;
            if(n < 0)
            {
                throw new NegativeNumberException();
            }
            while (n != 0)
            {
                if (number > 15)
                {
                    number = 0;
                    counter++;
                }
                if (number == 0)
                {
                    hexa.Add(Convert.ToString(number));
                }
                hexa[0] = Convert.ToString(number);
                number++;
                n--;
            }
            foreach(string i in hexa)
            {
                hexad += i;
            }
            return hexad;
        }
    }
}
