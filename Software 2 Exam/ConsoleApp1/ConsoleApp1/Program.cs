using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program


    /*David Gordon
     *S00189689
     * 16/May/2019
     * Question 1
     */

    {
        private static string line_In;

        static void Main(string[] args)
        {

            try
            {
                CSV_File();

                Console.ReadLine();
            }// end of the try block

            catch (IOException p) // to catch an io exception
            {
                Console.WriteLine(p.Message);
                Console.ReadLine();
            }
            catch (IndexOutOfRangeException M) // to catch an index problems
            {
                Console.WriteLine(M.Message);
                Console.ReadLine();
            }

            catch (Exception l)// to catch any exception
            {
                Console.WriteLine(l.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("did you save your work");
                Console.ReadLine();
            }

        }


        static void CSV_File()
        {

            int a, s, d, f;

            FileStream fs = new FileStream(@"ticketsales.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);




            // string line_In;

            string[] field_Arrary = new string[3];


            line_In = sr.ReadLine();

           
         
            Console.WriteLine("{0,-20}{1,-15}{2,-15}\n", "Ticket Type", "Tickets Sold", "Total Retail Value");

            while (line_In != null)
            {

                field_Arrary = line_In.Split(',');

                string Ticket_type = field_Arrary[1];

                int tickets = int.Parse(field_Arrary[2]);



              

                if (Ticket_type == "Basic")
                {
                    
                    tickets += a;

                }

                else if (Ticket_type == "Super")
                {
                    tickets += s ;
                }

                else if (Ticket_type == "Delux")
                {
                    tickets += d;
                }

                else if (Ticket_type == "VIP")
                    tickets += f;


               // Console.WriteLine("{0,-20}{1,-15}{2,-15}", field_Arrary[0], field_Arrary[1], field_Arrary[2]);


                Console.WriteLine("{0,-20}", a);








                line_In = sr.ReadLine();

            }// end of the while loop


            sr.Close();

            Console.WriteLine("{0,-20}",a);
     





        }//end of the csv methored
    }
}