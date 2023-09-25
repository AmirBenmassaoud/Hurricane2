using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter wind speed");
            double Mycat = Convert.ToDouble(Console.ReadLine());
            
            String catagories = ((Catagories)Mycat).ToString();
            
            System.Console.WriteLine(catagories);

            System.Console.WriteLine("Press Enter to exit");

            System.Console.ReadLine();


        }
    }

    enum Catagories
    {
        Not=70,
        Cat2=97,
        Cat4=152,
        Cat5=175
                 }
}
