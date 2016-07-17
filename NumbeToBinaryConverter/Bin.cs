﻿using System;
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

        public static string decimalToHexadecimal(ulong n)
        {
            int[] hexa = new int[(int)Math.Floor(Math.Log(n, 16)) + 1];
            string hexad = "";
            while (n > 0)
            {
                for (int i = 0; i < hexa.Length; i++)
                {
                    if (hexa[i] == 16)
                    {
                        hexa[i + 1]++;
                        hexa[i] = 0;
                    }
                }
                hexa[0]++;
                n--;
            }
            for (int i = 0; i < hexa.Length; i++)
            {
                if (hexa[i] == 16)
                {
                    hexa[i + 1]++;
                    hexa[i] = 0;
                }
            }
            Array.Reverse(hexa);
            foreach (int i in hexa)
            {
                switch (i)
                {
                    case 15:
                        hexad += "F";
                        break;
                    case 14:
                        hexad += "E";
                        break;
                    case 13:
                        hexad += "D";
                        break;
                    case 12:
                        hexad += "C";
                        break;
                    case 11:
                        hexad += "B";
                        break;
                    case 10:
                        hexad += "A";
                        break;
                    default:
                        hexad += Convert.ToString(i);
                        break;
                }
            }
            return hexad;
        }
    }
}
