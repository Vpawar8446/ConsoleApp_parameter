using System;

namespace ConsoleApp_parameter
{
    class Param
    {
        public void display(params object[] list)
        {
            foreach(object name in list )
            {
                Console.WriteLine(name);
                
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Param obj = new Param();
            obj.display(101,"Vaishnavi","Pawar",'U','@');
        }
    }
}
