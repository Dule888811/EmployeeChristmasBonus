using EmployeeNumber;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeChristmasBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Entrance();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska: {0}", ex.Message);
            }

        }
        static void Entrance()
        {
            var workersWithGif = new int[1000];
            int numberOfWorkersWithGit = 0;
            for (int ii = 2; ii <= 1000; ii++)
            {
                var printing = new bool[2];
                 printing[1] = true;
               
                int k = 1;
                int j = 1;
                var Array1 = new int[1000];
                foreach (int f in Array1)
                {
                    Array1[f] = 0;
                }

                int[] Array2 = new int[1000];
                foreach (int u in Array2)
                {
                    Array2[u] = 0;
                }
                List<int> Divisors = new List<int>();
                Divisors = Divisor.GetDevisiors(Divisors, ii);
              
                    var Dev = new int[1000];
                    int p = 1;
                    int n = Divisors.Count();
                    foreach (int d in Divisors)
                    {
                        Dev[p] = d;
                        p++;
                    }

                    for (k = 1; k <= n; k++)
                    {
                    Variation.Variations(Array1, Array2, printing, ii, n, k, j, Dev);
                    }

                    if (printing[1] == true)
                    {
                   
                    numberOfWorkersWithGit++;
                        workersWithGif[numberOfWorkersWithGit] = ii;
                        printing[1] = false;

                }
                else
                {
                    continue;
                }
               
               // Console.ReadLine();
                /*  */
                


            }
            Console.WriteLine("  number   {0} ", numberOfWorkersWithGit);
            List<int> Workers = new List<int>();
            Workers = workersWithGif.ToList();
            var workers = Workers.Skip(1).Take(numberOfWorkersWithGit);
            foreach (int w in workers)
            {
                Console.WriteLine("  workers   {0} ", w);
            }
            Console.ReadLine();

        }
            

        }
        
           
        }
    
    



