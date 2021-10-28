using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingPosetive
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int[] number;
           
            int[] posetiveNumber;
            Console.WriteLine("Enter the tottal count of numbers which you want to check ");
            num = Convert.ToInt32(Console.ReadLine());
            number = new int[num];

            for(int i=0;i<num;i++)
            {
                Console.WriteLine("enter number please");
                number[i] = Convert.ToInt32(Console.ReadLine());
               

            }
            
            posetiveNumber = new int[num];
            for(int i=0;i<num;i++)
            {
              
                if(number[i]>0)
                {
                    posetiveNumber[i] = number[i];
                    Console.WriteLine("posetive numbers are"+posetiveNumber[i]);
                    
                }
            }
        }
    }
}
