using System;

namespace Kabanova4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество цифр в двоичном числе (до 15):");
                int n = int.Parse(Console.ReadLine());
                int[] mas = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = rnd.Next(0, 2);
                    Console.Write(mas[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Введите получившееся сгенерированное двоичное число:");
                ulong x = 0;
                ulong ost = 0, itog = 0, count = 0, s = 0;
                x = ulong.Parse(Console.ReadLine());
                while (x > 0)
                {
                    ost = x % 10;
                    s = Convert.ToUInt64(Math.Pow(2, count));
                    itog = itog + ost * s;
                    count += 1;
                    x = x / 10;
                }
                Console.WriteLine("Десятичное число = {0}", itog);

                Console.WriteLine($"Число для перевода в шестнадцатиричную систему = {itog}");
                ulong m = itog;
                string res = "";
                while (m >= 16)
                {

                    switch (m % 16)
                    {
                        case 10: res += "A"; break;
                        case 11: res += "B"; break;
                        case 12: res += "C"; break;
                        case 13: res += "D"; break;
                        case 14: res += "E"; break;
                        case 15: res += "F"; break;
                        default: res += (m % 16).ToString(); break;
                    }
                    m /= 16;
                }
                switch (m)
                {
                    case 10: res += "A"; break;
                    case 11: res += "B"; break;
                    case 12: res += "C"; break;
                    case 13: res += "D"; break;
                    case 14: res += "E"; break;
                    case 15: res += "F"; break;
                    default: res += m.ToString(); break;
                }
                string result = "";
                for (int i = res.Length - 1; i >= 0; i--)
                {
                    result += res[i];
                }
                Console.WriteLine($"{result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
    
}
