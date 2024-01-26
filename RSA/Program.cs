using System;
using System.Numerics;

namespace RSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int GCD(int A, int B)  //GCD by Euclidean Algorithm
            {
                int T;
                while (B != 0)
                {
                    T = B; 
                    B = A % B; 
                    A = T;
                }
                return int.Abs(A);
            }
            
            static int GeneratePrime()
            {
                int num = 0;
                

                return num;
            }
            

        }
        
    }
}