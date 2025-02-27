using System;
using System.ComponentModel.DataAnnotations;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {

                //Todos os valores maximos
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(Int128.MaxValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(ulong.MaxValue);

                //Todos os valores minimos
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(Int128.MinValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(decimal.MinValue);

            //Valores especiais float and double
            Console.WriteLine(float.PositiveInfinity);
            Console.WriteLine(float.NegativeInfinity);
            Console.WriteLine(float.NaN);
            
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.NaN);




            uint u = uint.MaxValue; // overflow
            Console.WriteLine(u+1);

            float f = float.MaxValue; //dois tipos differentes de overflow
            Console.WriteLine(f+1);
            Console.WriteLine(f*2);

            
        }
    }
}
