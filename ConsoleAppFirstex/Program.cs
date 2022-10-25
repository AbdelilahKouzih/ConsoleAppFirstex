using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppFirstex // Note: actual namespace depends on the project name.
{
    class Program
    {

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
                Console.WriteLine("votre nombre n'est pas premier");
            }
            else
            {
                Console.WriteLine("votre nombre est premier");

            }
        }



        static void Main(string[] args)
        
        
        {

            Estpremier(5);
           
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
   