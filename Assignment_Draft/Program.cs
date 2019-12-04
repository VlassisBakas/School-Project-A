using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Assignment_Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"         To enter data press 1       ");
            Console.WriteLine($"     To use synthetic data press 2   ");
            Console.WriteLine($"             To exit press 3      ");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Input.InputData();
                        break;
                case 2:
                    SyntheticData.ReadDataBase();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
 


            }
           

    

        }


    }


}
