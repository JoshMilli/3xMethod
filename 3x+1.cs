using System;
using System.Threading;
using System.IO;


namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        
        Calculations Check = new Calculations();

        int x = 845;
        Console.WriteLine("Starting Number: "+x);
        int ans = Check.Check(x);
        int counter = 1;
        while (ans>0)
        {
            
            Calculations Redo = new Calculations();
            int c = Redo.Check(ans);
            
            counter++;
            Console.WriteLine("Next Number: "+c);
            ans = c;

            if (ans==1)
            {
               
                Console.WriteLine("Count is: "+counter);
                break;
            }
            
        }
        
        
        
    }
  }
  
  
  
  
  
}