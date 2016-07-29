using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbeToBinaryConverter
{
    static class NumericBases
    {   
        public static string decimalToBinary(ulong n)
        {
            string bin = "";
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
            if(n == 0)
            {
                return "0";
            }
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

        public static ulong binaryToDecimal(string bin)
        {
            ulong dec = 0;
            char[] bina = bin.ToCharArray();

            for (int i = 0; i < bina.Length; i++)
            {
                if (bina[i] == Convert.ToChar("1"))
                {
                    bina[i] = Convert.ToChar("0");
                    dec += (ulong) Convert.ToInt32(Math.Pow(2, bina.Length - (i + 1)));
                }
            }
            return dec;
        }

        public static ulong hexadecimalToDecimal(string hexa)
        {
            ulong[] hexad = new ulong[hexa.Length];
            ulong dec = 0;
            for (int i = 0; i < hexad.Length; i++)
            {
                if (hexa[i] == Convert.ToChar("F"))
                {
                    hexad[i] = 15;
                }
                else if (hexa[i] == Convert.ToChar("E"))
                {
                    hexad[i] = 14;
                }
                else if (hexa[i] == Convert.ToChar("D"))
                {
                    hexad[i] = 13;
                }
                else if (hexa[i] == Convert.ToChar("C"))
                {
                    hexad[i] = 12;
                }
                else if (hexa[i] == Convert.ToChar("B"))
                {
                    hexad[i] = 11;
                }
                else if (hexa[i] == Convert.ToChar("A"))
                {
                    hexad[i] = 10;
                }
                else
                {
                    hexad[i] = Convert.ToUInt32(Convert.ToString(hexa[i]));
                }
            }
            Array.Reverse(hexad);
            for (int i = 0; i < hexad.Length; i++)
            {
                Console.WriteLine(hexad[i]);
                if (i == 0)
                {
                    dec += hexad[i];
                }
                else
                {
                    dec += hexad[i] * Convert.ToUInt32(Math.Pow(16, i));
                }
            }
            return dec;
        }
    }
}
