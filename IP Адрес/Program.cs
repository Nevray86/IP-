using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Адрес
{
    /// <summary>
    /// запрашивает ip и маску и выводит на экран
    /// </summary>
    internal class Program
    {


       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           
           

            
            Console.WriteLine("Введите IP");

            

            string ip;
            int[] IP;
            IP = new int[4];
            

            
            for (int i = 0; i < 4; i++)
            {



               


                if (i < 2)
                {
                    int count = 0;
                    Console.Write(i + 1); Console.Write(" актет ");
                    do


                    {


                        ip = Console.ReadLine();
                        count++;
                    } while (ip.Length != 3);


                    IP[i] = Convert.ToInt32(ip);
                }
                else
                {
                    int count = 0;
                    Console.Write(i + 1); Console.Write(" актет ");
                    do


                    {


                        ip = Console.ReadLine();
                        count++;
                    } while (ip.Length  != 1 && ip.Length != 2 && ip.Length != 3);

                    IP[i] = Convert.ToInt32(ip);

                   
                    
                }

            }
            
            Console.Write("ip = ");
            for (int i = 0; i < 4; i++)
            {

                
                
                if(i < 3)
                {
                    Console.Write(IP[i]); Console.Write(".");
                }
                else
                {
                    Console.WriteLine(IP[i]); 
                }
            }
            

            Console.WriteLine("Введите Mask");


            string mask;
            int[] Mask;
            Mask = new int[4];

            for (int i = 0; i < 4; i++)
            {





                if (i < 2)
                {
                    int count = 0;
                    Console.Write(i + 1); Console.Write(" актет ");
                    do


                    {


                        mask = Console.ReadLine();
                        count++;
                    } while (mask.Length != 3);


                    Mask[i] = Convert.ToInt32(mask);
                }
                else
                {
                    int count = 0;
                    Console.Write(i + 1); Console.Write(" актет ");
                    do


                    {


                        mask = Console.ReadLine();
                        count++;
                    } while (mask.Length != 1 && mask.Length != 2 && mask.Length != 3);

                    Mask[i] = Convert.ToInt32(mask);



                }

            }
            Console.Write("mask = ");
            for (int i = 0; i < 4; i++)
            {



                if (i < 3)
                {
                    Console.Write(Mask[i]); Console.Write(".");
                }
                else
                {
                    Console.WriteLine(Mask[i]);
                }
            }
        }
    }
}
