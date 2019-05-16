using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {

        
        static void Main(string[] args)
        {


            Bike[] NewBike = new Bike[4];

            NewBike[0] = new Bike("Honda", 123546, 10000);
            NewBike[1] = new E_Bike("rover", 445, 1000, 10);
            NewBike[2] = new Bike("Ducatiu", 156, 15500.36);
            NewBike[3] = new E_Bike("Billybong", 64548976, 1500, 15);



            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine(NewBike[i].ToString());
                Console.WriteLine(NewBike[i].CalcDeposit());
                Console.WriteLine();
            }

        }
    }
}
