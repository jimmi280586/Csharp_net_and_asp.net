using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_library
{
    public class Class1
    {
        public string print_every_second()
        {
            for(int i=100; i<203; i++)
            {
                if (i == 100)
                {
                    Console.WriteLine("" + i);
                }
                else
                {
                    i++;
                    Console.WriteLine("" + i);                    
                }
            }           
            return "";
        }

        public string print_every_second_reverse()
        {
            for (int i = 202; i > 99; i--)
            {
                if (i == 202)
                {
                    Console.WriteLine("" + i);
                }
                else
                {
                    i--;
                    Console.WriteLine("" + i);
                }
            }           
            return "";
        }

        public void Print_exercise_1_03()
        {
            int a = 100;
            int b = 202;
            while(a<=b)
             {
                switch(a)
                {
                    case 110:
                        Console.WriteLine(a + " This is a funny number");
                        break;
                    case 130:
                        Console.WriteLine(a + " This is a funny number");
                        break;
                    case 140:
                        Console.WriteLine(a + " This is a funny number");
                        break;
                    case 122:
                        Console.WriteLine(a + " This is my lucky number");
                        break;
                    case 198:
                        Console.WriteLine(" This number will not be printed");
                        break;
                    default:
                        Console.WriteLine(a);
                        break;
                }
               
                a++;
                a++;

             }
        }

        public void print_exercise_1_04()
        {
            for(int i=1;i<256;i++)
            {
                // Convert the decimal value to a hexadecimal value in string form.
                string hexOutput = String.Format("{0:X}", i);
                Console.WriteLine("Hexadecimal value of {0} is {1}", i, hexOutput);
            }
        }

        public string makeSomeNoise()
        {            
            return "Peep";
        }
    }
}
