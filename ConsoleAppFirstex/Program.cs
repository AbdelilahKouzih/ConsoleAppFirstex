using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppFirstex // Note: actual namespace depends on the project name.
{
    class Program
    {

       



        public static void InsererInt(int y)
        {
            
            int[] tab = {1,2,3,4,5,6};

            /*Console.WriteLine("veuillez entrer votre nombre");
             int y =Console.Read();*/

           
            int x = tab.Length-1;

            for(int i=x;i<=0;i--)
            {
                if (y > tab[i])
                {
                    tab[i] = tab[i-1];
                    i = i - 1;
                    tab[i] = y;
                   
                    
                }

            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }



        }





        public static void Estpremier(int x) 
        {
            /*Console.WriteLine("veuillez entrer nombre");
            int Entre = Console.Read();*/
            
           
            int verif = 0;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    verif++;
                }

            }

            if (verif != 0)
            {
                Console.WriteLine("votre nombre n'est pas Premier");
            }
            else
            {
                Console.WriteLine("votre nombre est premier");

            }
        }



        static void Main(string[] args)
        
        
        {

           // Estpremier(5);
            InsererInt(9);
           
        }
}
        
        
        
        
        

        





}




    /* Console.WriteLine("veuillez entrer nombre");
     int Entre = Console.Read();


     int verif=0; 
     for(int i=2;i<= Math.Sqrt(Entre);i++)
     {
         if(Entre%i==0)
         {
             verif++;
         }

     }

     if (verif != 0)
     { 
         Console.WriteLine("votre nombre n'est pas premier");
     }
     else
     { 
         Console.WriteLine("votre nombre est premier");

     }
 }
}
}*/
   