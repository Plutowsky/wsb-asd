using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1_Algorytmy
{
    class Program
    {
        bool IsPresent(int[] Vector, int Number)
        {
            for (int i = 0; i < Vector.Length; i++)
            
                
                if (Vector[i] == Number) return true;
                return false;
            
        }
        
        static void Main(string[] args)
        {
            int[] vector = new int[7];

            vector[0] = 1;
            vector[1] = 2;
            vector[2] = 3;
            vector[3] = 4;
            vector[4] = 5;
            vector[5] = 6;
            vector[6] = 7;


            Console.WriteLine("Podaj liczbe");
            int Number = int.Parse(Console.ReadLine());

            /*for(int i=0;i<vector.Length ;i++)
            {
                vector[i] = i;
                Console.WriteLine(vector[i]);
            }*/
            
            IsPresent(vector[], Number);

            Console.ReadKey();
        }
    }
}